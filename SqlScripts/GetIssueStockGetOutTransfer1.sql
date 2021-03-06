
  
ALTER Proc [dbo].[GetIssueStockGetOutTransfer1]   
@ProjID varchar(50),  
@itemGroup varchar(50)='',  
@itemId varchar(50)='',  
@EmpId varchar(50)='0',  
@blockName varchar(max)  
As  
Begin  
  
Select IQ.ProjectID,IQ.Issue_Date,IQ.Id as IssueNo,IQ.IndentNo,IQ.ItemGroupID,IQ.ItemGroupName,IQ.ItemID,IM.GITEMCode as ItemCode,  
IQ.ItemName,UM.UnitID,UM.UnitName,case when BlockName IS null then 'N/A' else BlockName end as BlockName,   
convert(decimal(18,3),IQ.IssueQuantity-ISNULL(ReturnQty,0)) as IssueQuantity,IQ.Receive_Rate as Rate,convert(decimal(18,2),IsNull(((IQ.IssueQuantity-ISNULL(ReturnQty,0)) * IQ.Receive_Rate), 0)) as IssueAmount,    
Case When IQ.PcContractorId is Null Or IQ.PcContractorId = '' Then 'VID0000005' Else IQ.PcContractorId End EmployeeID,  
  
CASE WHEN IQ.Optional_Name IS NULL or IQ.Optional_Name='' THEN '--' Else IQ.Optional_Name END Optional_Name,   
  
case when FS.FinancialType is null then '--' else FS.FinancialType end FinancialType,   
Case when IQ.IndentNo like '%TRN%' then (select projectName from tblProjectMaster P where P.PRJID=IQ.SiteId) When PM.Name is Null Then 'Other' Else PM.Name End IssuedTo,  
  
IM.GITEMCode as ItemCode,IM.HSNCode, IQ.Issue_Type as IssueType ,'Issue' as Type, IssueBill_No  
  
from ns_tbl_IssueQuantity IQ   
  
left join tblFinancialSelectionType FS on IQ.Financial_Type = FS.TransId   
  
Inner Join tblItemMaster IM ON IM.ItemID = IQ.ItemID   
  
Inner Join tblUnitMaster UM ON UM.UnitID = IM.UnitID   
  
--Left Outer Join tblPcContractorMaster PM ON PM.PcContractorID = IQ.PcContractorId   
  Left Outer Join SITA_PMC.dbo.tblVendorMaster PM ON PM.VendorID = IQ.PcContractorId   

where IQ.ProjectID=@ProjID and (@itemGroup='' or IQ.itemGroupid=@itemGroup) and (@itemId='' or IQ.itemId=@itemId)   
   and (@EmpId='0' or IQ.PcContractorId=@EmpId) and (@blockName='' or IQ.BlockName=@blockName) and IQ.IssueQuantity!=0   
   and Issue_type<>'Vendor Debit Note Transfer'  
   order by IQ.Issue_Date desc  
  
End  
  
  