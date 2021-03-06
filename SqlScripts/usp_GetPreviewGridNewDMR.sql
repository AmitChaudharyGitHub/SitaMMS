
ALTER  Procedure [dbo].[usp_GetPreviewGridNewDMR]    
 @GRN varchar(50)='',    
 @MRN_No varchar(50)='',
 @ItemNo varchar(50)='',
 @RecQty decimal(18,3)=0.0,
 @Cartage decimal(18,3)=0.0     
    
As    
Begin    


;with CTEItemGrid
as
(
Select Convert(bigint,ROW_NUMBER() OVER(ORDER BY y.UId asc)) as Sno, x.ProjectNo,x.ProjectName,x.GateEntryNo,x.StatusTypeNo as PONumber,z.CartageTypeId,CT.CartageType, 
y.ItemGroupNo,y.ItemGroup as GroupName,y.Item as ItemName,y.ItemNo,y.UnitNo,y.Unit as UnitCode,k.IndentRefNo as PurchaseIndentNo,
z.Qty as POQty, y.ReceiveQty as GateEntryRecvQty, x.ChallanNo,x.VehicleNo ,y.UId as GateEntryChildId, x.GateEntryId ,z.UId as POChildId ,z.MUId as POID,y.MRN_Receive , NewRate as Rate , @RecQty Receive,
z.Item_ExcessPercentage, (z.Item_ExcessQuantity + z.Qty) as Item_ExcessQuantity, @Cartage as CartageAmount, InsuranceRate, PackingChargesPercentage, InsuranceAmount,
(Select((@RecQty*NewRate)-((@RecQty*NewRate)*(isnull(Discount,0)/100)))) as DiscountAmt,Discount as DiscountPercentage,CGSTPercentage,SGSTPercentage,IGSTPercentage,
CGSTAmount, SGSTAmount, IGSTAmount, GrossAmount
--,((Select((ReceiveQty*NewRate)-((ReceiveQty*NewRate)*(isnull(Discount,0)/100))))*Isnull(PackingChargesPercentage/100,0)) as PandF
--,(CartageAmount+(Select((ReceiveQty*NewRate)-((ReceiveQty*NewRate)*(isnull(Discount,0)/100))))+((Select((ReceiveQty*NewRate)
---((ReceiveQty*NewRate)*(isnull(Discount,0)/100))))*Isnull(PackingChargesPercentage/100,0))) as CAmount
--,(CartageAmount+(Select((ReceiveQty*NewRate)-((ReceiveQty*NewRate)*(isnull(Discount,0)/100))))+((Select((ReceiveQty*NewRate)
---((ReceiveQty*NewRate)*(isnull(Discount,0)/100))))*Isnull(PackingChargesPercentage/100,0)))*Isnull(InsuranceRate/100,0) as IncAmt
--,(CartageAmount+(Select((ReceiveQty*NewRate)-((ReceiveQty*NewRate)*(isnull(Discount,0)/100))))+((Select((ReceiveQty*NewRate)
---((ReceiveQty*NewRate)*(isnull(Discount,0)/100))))*Isnull(PackingChargesPercentage/100,0)))+(CartageAmount+(Select((ReceiveQty*NewRate)-
--((ReceiveQty*NewRate)*(isnull(Discount,0)/100))))+((Select((ReceiveQty*NewRate)
---((ReceiveQty*NewRate)*(isnull(Discount,0)/100))))*Isnull(PackingChargesPercentage/100,0)))*Isnull(InsuranceRate/100,0) as TaxableAmt
 from GateEntry_Mid x inner join GateEntryChild_Mid y on x.UId=y.MUId
inner  join TbIndentPurchaseOrderChild_GST z on z.UId = y.StatusChildId 
Inner join TbIndentPurchaseOrder_GST k on z.MUId= k.UId
left join tblMMSCartageType CT on CT.TransId=z.CartageTypeId
where x.GateEntryNo=@GRN and y.ItemNo=@ItemNo
)

--else cartageamt  (DiscountAmt+DiscountAmt*Isnull(PackingChargesPercentage/100,0)+CartageAmount)
select *,Receive as Qty, DiscountAmt as Discount,CGSTPercentage as CGSTPer, SGSTPercentage as SGSTAndUTGSTPer, IGSTPercentage as IGSTPer, 
(DiscountAmt*Isnull(PackingChargesPercentage/100,0)) as PandF,  case when CartageTypeId in (3,4,5) and CartageAmount>0 then 
CartageAmount else (CartageAmount*@RecQty)/POQty end as CartageAmt, 
case when CartageTypeId in (3,4,5) and CartageAmount>0 then (DiscountAmt+DiscountAmt*Isnull(PackingChargesPercentage/100,0)
+CartageAmount)* Isnull(InsuranceRate/100,0) else (InsuranceAmount*Receive)/POQty end as  InsuranceAmt,

case when CartageTypeId in (3,4,5) and CartageAmount>0 then (((DiscountAmt+DiscountAmt*Isnull(PackingChargesPercentage/100,0)+CartageAmount)+(case when CartageTypeId in (3,4,5) and CartageAmount>0
then (DiscountAmt+DiscountAmt*Isnull(PackingChargesPercentage/100,0)+CartageAmount)* Isnull(InsuranceRate/100,0) else 
(InsuranceAmount*Receive)/POQty end ))*CGSTPercentage)/100 else (CGSTAmount*Receive)/POQty end as CGSTAmt,
case when CartageTypeId in (3,4,5) and CartageAmount>0 then (((DiscountAmt+DiscountAmt*Isnull(PackingChargesPercentage/100,0)+CartageAmount)+(case when CartageTypeId in (3,4,5) and CartageAmount>0
then (DiscountAmt+DiscountAmt*Isnull(PackingChargesPercentage/100,0)+CartageAmount)* Isnull(InsuranceRate/100,0) else 
(InsuranceAmount*Receive)/POQty end ))*SGSTPercentage)/100 else (SGSTAmount*Receive)/POQty end as SGSTAndUTGSTAmt,
case when CartageTypeId in (3,4,5) and CartageAmount>0 then (((DiscountAmt+DiscountAmt*Isnull(PackingChargesPercentage/100,0)+CartageAmount)+(case when CartageTypeId in (3,4,5) and CartageAmount>0
then (DiscountAmt+DiscountAmt*Isnull(PackingChargesPercentage/100,0)+CartageAmount)* Isnull(InsuranceRate/100,0) else 
(InsuranceAmount*Receive)/POQty end ))*IGSTPercentage)/100 else (IGSTAmount*Receive)/POQty end as IGSTAmt,

(DiscountAmt+(DiscountAmt*Isnull(PackingChargesPercentage/100,0))+CartageAmount) as CalAmt into #tempItemInfo
--(case when CartageTypeId in (3,4,5) and CartageAmount>0 then (((DiscountAmt+
--DiscountAmt*Isnull(PackingChargesPercentage/100,0)+CartageAmount)+(case when CartageTypeId in (3,4,5) and CartageAmount>0
--then (DiscountAmt+DiscountAmt*Isnull(PackingChargesPercentage/100,0)+CartageAmount)* Isnull(InsuranceRate/100,0) else 
--(InsuranceAmount*Receive)/POQty end ))*CGSTPercentage)/100 else (CGSTAmount*Receive)/POQty end)+
--(case when CartageTypeId in (3,4,5) and CartageAmount>0 then (((DiscountAmt+DiscountAmt*Isnull(PackingChargesPercentage/100,0)+CartageAmount)+(case when CartageTypeId in (3,4,5) and CartageAmount>0
--then (DiscountAmt+DiscountAmt*Isnull(PackingChargesPercentage/100,0)+CartageAmount)* Isnull(InsuranceRate/100,0) else 
--(InsuranceAmount*Receive)/POQty end ))*SGSTPercentage)/100 else (SGSTAmount*Receive)/POQty end)+
--(case when CartageTypeId in (3,4,5) and CartageAmount>0 then (((DiscountAmt+DiscountAmt*Isnull(PackingChargesPercentage/100,0)+CartageAmount)+(case when CartageTypeId in (3,4,5) and CartageAmount>0
--then (DiscountAmt+DiscountAmt*Isnull(PackingChargesPercentage/100,0)+CartageAmount)* Isnull(InsuranceRate/100,0) else 
--(InsuranceAmount*Receive)/POQty end ))*IGSTPercentage)/100 else (IGSTAmount*Receive)/POQty end)

 --as GrandTotal
  From CTEItemGrid

  select GroupName, ItemNo, ItemName, UnitCode, QTy, Rate, DiscountPercentage, convert(decimal(18,2),Discount) as Discount, CONVERT(decimal(18,2), PandF) as PandF,
  convert(decimal(18,2),CartageAmt) as CartageAmt, convert(decimal(18,2),InsuranceAmt) as InsuranceAmt, convert(decimal(18,2),CGSTPer) as CGSTPer, 
  convert(decimal(18,2),SGSTAndUTGSTPer) as SGSTAndUTGSTPer,convert(decimal(18,2),IGSTPer) as IGSTPer,  convert(decimal(18,2),CGSTAmt) as CGSTAmt,  
  convert(decimal(18,2),SGSTAndUTGSTAmt) as SGSTAndUTGSTAmt,  convert(decimal(18,2),IGSTAmt) as IGSTAmt,
   convert(decimal(18,2),(case when CartageTypeId in (3,4,5) and CartageAmt>0 then (CalAmt+InsuranceAmt)+(((CalAmt+InsuranceAmt)*CGSTPer)/100) 
  +(((CalAmt+InsuranceAmt)*SGSTPercentage)/100)+(((CalAmt+InsuranceAmt)*IGSTPer)/100) else 
  (GrossAmount*@RecQty)/POQty
   end)) as GrandTotal from #tempItemInfo 
    
	drop table #tempItemInfo
End  
  
