using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DATA
{
    internal static class WellKnownStoredProcedures
    {
        #region Select's SP's
        internal static class SelectSPs
        {
            public static string SelectTrainingCompletionResultValues = "SelectTrainingCompletionResultValues";

            public static string SelectBackgroundDetailsForLeaveApproval = "SelectBackgroundDetailsForLeaveApproval";

            public static string SelectPendingScheduledAppraisalsForThisUser = "SelectPendingScheduledAppraisalsForThisUser";

            public static string SelectAllWorkFlowApprovalLogDetails = "SelectAllWorkFlowApprovalLogDetails";
            public static string SelectAllWorkFlowApprovalLogDetailsForEmployeeConfirmation = "SelectAllWorkFlowApprovalLogDetailsForEmployeeConfirmation";

            public static string SelectTrainingScheduleDetailsForCompletionGrid = "SelectTrainingScheduleDetailsForCompletionGrid";

            public static string SelectTrainingScheduleHeaderDetailsForCompletionComboBox = "SelectTrainingScheduleHeaderDetailsForCompletionComboBox";

            public static string SelectDesignationWiseTrainingDetails = "SelectDesignationWiseTrainingDetails";

            public static string SelectTrainingScheduleHeader = "SelectTrainingScheduleHeader";

            public static string SelectTrainingScheduleDetails = "SelectTrainingScheduleDetails";

            public static string SelectTrainingRequestDetails = "SelectTrainingRequestDetails";

            public static string SelectAllTrainingRequestDetailsReport = "SelectAllTrainingRequestDetailsReport";

            public static string SelectTrainingCategoryDetails = "SelectTrainingCategoryDetails";

            public static string SelectTerminationDueList = "SelectTerminationDueList";
            public static string rptSelectTerminationDueList = "rpt_SelectTerminationDueList";

            public static string SelectDesignationWiseCollectablesByEmployeeId = "SelectDesignationWiseCollectablesByEmployeeId";

            public static string SelectEmployeeWiseCollectableItems = "SelectEmployeeWiseCollectableItems";

            public static string SelectDesignationWiseCollectables = "SelectDesignationWiseCollectables";

            public static string SelectEmployeeCollectableItemsCheckList = "SelectEmployeeCollectableItemsCheckList";

            //************************* TERMINATION *******************************************************
            public static string SelectEmployeeTerminationInitiate = "SelectEmployeeTerminationInitiate";

            public static string SelectAllActiveTerminationInitiatedEmployeeDetails = "SelectAllActiveTerminationInitiatedEmployeeDetails";

            public static string SelectTerminationReason = "SelectTerminationReason";

            public static string SelectCompanyWiseTerminationEntitlementForTerminationCategory = "SelectCompanyWiseTerminationEntitlementForTerminationCategory";

            public static string SelectAllTerminationEntitlementList = "SelectAllTerminationEntitlementList";

            public static string SelectTerminationCategories = "SelectTerminationCategories";

            //--For report--
            public static string rptSelectThisEmployeeTerminationDetails = "rpt_SelectThisEmployeeTerminationDetails";

            //********************************************************************************************

            public static string SelectAllAppraisalElementWiseQuestionDetailsBySubCat = "SelectAllAppraisalElementWiseQuestionDetailsBySubCat";

            public static string SelectAppraisalScheduleDataDetails = "SelectAppraisalScheduleDataDetails";

            public static string SelectAllAppraisalScheduleDataDetailForApproval = "SelectAllAppraisalScheduleDataDetailForApproval";

            public static string SelectAppraisalScheduleDataHeader = "SelectAppraisalScheduleDataHeader";

            public static string SelectAppraslSchedule = "SelectAppraslSchedule";

            public static string SelectAllAppraisalType_TypeDetails = "SelectAllAppraisalType_TypeDetails";

            public static string SelectAppraisalElimentWiseQuestionHeaderDetails = "SelectAppraisalElimentWiseQuestionHeaderDetails";

            public static string SelectAllAppraisalElementWiseQuestionDetails = "SelectAllAppraisalElementWiseQuestionDetails";

            public static string SelectActiveListOfHeaderAttributes = "SelectActiveListOfHeaderAttributes";
            public static string SelectListOfAttributeHeaderDetailsFromListOfAttributeHeaderId = "SelectListOfAttributeHeaderDetailsFromListOfAttributeHeaderId";

            public static string SelectLetterTemplateDetails = "SelectLetterTemplateDetails";
       
            public static string SelectDesignationWiseWorkFlowDetails = "SelectDesignationWiseWorkFlowDetails";
       
            public static string SelectAllForwordableEmployees = "SelectAllForwordableEmployees";

            public static string SelectAllAvailableDesignationSlotDetailsForReleventDesignation = "SelectAllAvailableDesignationSlotDetailsForReleventDesignation";
            public static string SelectAllTopDesignationsFromParameterDesignation = "SelectAllTopDesignationsFromParameterDesignation";
            public static string SelectWorkFlowByProcessAndEmployee = "SelectWorkFlowByProcessAndEmployee";
            public static string SelectWorkFlowByProcessAndDesignation = "SelectWorkFlowByProcessAndDesignation";

            public static string SelectAllLeaveApprovalFlowDetails = "SelectAllLeaveApprovalFlow";
            public static string SelectThisLeaveApprovalFlowDetails = "SelectThisLeaveApprovalFlowDetails";

            public static string SelectThisLeveRequestForApproval = "SelectThisLeveRequestForApproval";

            public static string SelectPromotionRequestLogDetailsForApproval = "SelectPromotionRequestLogDetailsForApproval";
            public static string SelectAllmainMenuDetails = "SelectAllmainMenuDetails";
            public static string SelectThisGen_MainMenuByMainMenuID = "SelectThisGen_MainMenuByMainMenuID";

            public static string SelectAllPromotionRequestLogDetails = "SelectAllPromotionRequestLogDetails";
            public static string rptSelectThisPromotionRequestLogDetails = "rpt_SelectThisPromotionRequestLogDetails"; // for report

            public static string SelectThisUserHasPermissionsForRequest = "SelectThisUserHasPermissionsForRequest";
            public static string SelectCurrentPromotionRequestLogDetails = "SelectCurrentPromotionRequestLogDetails";
            public static string SelectDistinctCurrentDesignationPromotionRequestLogDetails = "SelectDistinctCurrentDesignationPromotionRequestLogDetails";
            public static string SelectAllPromotionRequestApprovalLogDetails = "SelectAllPromotionRequestApprovalLogDetails";

            public static string SelectThisUserWiseCompanyAccessDetails = "SelectThisUserWiseCompanyAccessDetails";
            public static string SelectAllUserWiseCompanyAccessDetailsByUserId = "SelectAllUserWiseCompanyAccessDetailsByUserId";

            public static string SelectAllDesignationsByUsingDepartments = "SelectAllDesignationsByUsingDepartments";

            public static string SelectAllNotCompletedCommitments = "SelectAllNotCompletedCommitments";
            public static string SelectAllCompletedCommitments = "SelectAllCompletedCommitments";
            public static string SelectBetweenDatesEmployeeWiseCommitmentLogDetails = "SelectBetweenDatesEmployeeWiseCommitmentLogDetails";
            public static string SelectAllEmployeeWiseCommitmentLogDetailsReport = "SelectAllEmployeeWiseCommitmentLogDetailsReport";

            public static string SelectAllIssuedItems = "SelectAllIssuedItems";
            public static string SelectAllIssuedAndNotReturnedItems = "SelectAllIssuedAndNotReturnedItems";
            public static string SelectAllEmployeeWiseBenifitDetailsByHeaderId = "SelectAllEmployeeWiseBenifitDetailsByHeaderId";

            public static string SelectAllEmployeeWiseBenifitHeaderDetails = "SelectAllEmployeeWiseBenifitHeaderDetails";
            public static string SelectThisEmployeeWiseBenifitHeaderDetails = "SelectThisEmployeeWiseBenifitHeaderDetails";
            public static string SelectNotAssetEmployeeWiseBenifitHeaderDetails = "SelectNotAssetEmployeeWiseBenifitHeaderDetails";
            public static string SelectIssuableEmployeeWiseBenifitHeaderDetails = "SelectIssuableEmployeeWiseBenifitHeaderDetails";
            public static string SelectAllEmployeeWiseBenifitHeaderDetailsByHeaderId = "SelectAllEmployeeWiseBenifitHeaderDetailsByHeaderId";
            public static string SelectAllIssueRenewableBenifits = "SelectAllIssueRenewableBenifits";

            public static string SelectAllAssetsInventoryDetailsByBenifitId = "SelectAllAssetsInventoryDetailsByBenifitId";

            public static string SelectAllEmployeeBenifitApproveLevelDetails = "SelectAllEmployeeBenifitApproveLevelDetails";
            public static string SelectThisEmployeeBenifitApproveLevelDetails = "SelectThisEmployeeBenifitApproveLevelDetails";

            public static string SelectAllDesignationWiseBenifitDetails = "SelectAllDesignationWiseBenifitDetails";
            public static string SelectThisDesignationWiseBenifitDetails = "SelectThisDesignationWiseBenifitDetails";
            public static string SelectThisEmployeeBenifitDetailsByBenifitId = "SelectThisEmployeeBenifitDetailsByBenifitId";
            public static string SelectDistinctDesignationWiseBenifitDetailsByDesignation = "SelectDistinctDesignationWiseBenifitDetailsByDesignation";

            public static string SelectAllEmployeeBenifitDetails = "SelectAllEmployeeBenifitDetails";
            public static string SelectThisEmployeeBenifitDetails = "SelectThisEmployeeBenifitDetails";
            public static string SelectAllActiveDesignationWiseBenifitDetailsFroEmployee = "SelectAllActiveDesignationWiseBenifitDetailsFroEmployee";

            public static string SelectAllCompanyWiseDesignationDetails = "SelectAllCompanyWiseDesignationDetails";
            public static string SelectPromotionAllowedDesignationDetails = "SelectPromotionAllowedDesignationDetails";
            public static string SelectThisCompanyWiseDesignationDetails = "SelectThisCompanyWiseDesignationDetails";
            public static string SelectAllActiveCompanyWiseDesignationDetails = "SelectAllActiveCompanyWiseDesignationDetails";

            public static string SelectAllEmployeeWiseAddressDetails = "SelectAllEmployeeWiseAddressDetails";
            public static string SelectThisEmployeeWiseAddressDetails = "SelectThisEmployeeWiseAddressDetails";
            public static string SelectThisEmployeeWiseAddressDetailsByEmployeeId = "SelectThisEmployeeWiseAddressDetailsByEmployeeId";

            public static string SelectAllCountryDetails = "SelectAllCountryDetails";
            public static string SelectThisCountryDetails = "SelectThisCountryDetails";
            public static string SelectAllActiveCountryDetails = "SelectAllActiveCountryDetails";

            public static string SelectAllLeaveApprovedLevelsDetails = "SelectAllLeaveApprovedLevelsDetails";
            public static string SelectThisLeaveApprovedLevelsDetails = "SelectThisLeaveApprovedLevelsDetails";
            
            public static string SelectAllCompanyWiseLeaveTypeDetails = "SelectAllCompanyWiseLeaveTypeDetails";
            public static string SelectThisCompanyWiseLeaveTypeDetails = "SelectThisCompanyWiseLeaveTypeDetails";
            public static string SelectThisCompanyWiseLeaveTypeDetailsByLeaveTypeId = "SelectThisCompanyWiseLeaveTypeDetailsByLeaveTypeId";

            public static string SelectAllLeaveTypeDetails = "SelectAllLeaveTypeDetails";
            public static string SelectThisLeaveTypeDetails = "SelectThisLeaveTypeDetails";

            public static string SelectAllEmployeeWiseInterestDetails = "SelectAllEmployeeWiseInterestDetails";
            public static string SelectThisEmployeeWiseInterestDetails = "SelectThisEmployeeWiseInterestDetails";
            public static string SelectThisEmployeeWiseInterestDetailsByEmployeeId = "SelectThisEmployeeWiseInterestDetailsByEmployeeId";

            public static string SelectAllEmployeeWiseRelationshipDetails = "SelectAllEmployeeWiseRelationshipDetails";
            public static string SelectThisEmployeeWiseRelationshipDetails = "SelectThisEmployeeWiseRelationshipDetails";
            public static string SelectThisEmployeeWiseRelationshipDetailsForGird = "SelectThisEmployeeWiseRelationshipDetailsForGird";

            public static string SelectAllStatusetails = "SelectAllStatusetails";
            public static string SelectAllCivilStatusDetails = "SelectAllCivilStatusDetails";
            public static string SelectAllCommunicationTypeDetails = "SelectAllCommunicationTypeDetails";
            public static string SelectThisCommunicationTypeDetails = "SelectThisCommunicationTypeDetails";

            public static string SelectAllTitleDetails = "SelectAllTitleDetails";

            public static string SelectAllClasificationDetails = "SelectAllClasificationDetails";
            public static string SelectThisClasificationDetails = "SelectThisClasificationDetails";
            public static string SelectThisClasificationDetailsByName = "SelectThisClasificationDetailsByName";
            public static string SelectThisEmployeeWiseClassficationDetails = "SelectThisEmployeeWiseClassficationDetails";
         

            public static string SelectAllRelationshipTypeDetails = "SelectAllRelationshipTypeDetails";
            
            public static string SelectAllRelationshipDetails = "SelectAllRelationshipDetails";
            public static string SelectThisRelationshipDetails = "SelectThisRelationshipDetails";
         

            public static string SelectAllBloodGroupDetails = "SelectAllBloodGroupDetails";
            public static string SelectThisBloodGroupDetails = "SelectThisBloodGroupDetails";
            public static string SelectAllActiveBloodGroupDetails = "SelectAllActiveBloodGroupDetails";
         

            public static string SelectAllDepartmentDetails = "SelectAllDepartmentDetails";
            public static string SelectAllActiveDepartmentDetails = "SelectAllActiveDepartmentDetails";
            public static string SelectThisDepartmentDetails = "SelectThisDepartmentDetails";
         
            public static string SelectAllBranchDetails = "SelectAllBranchDetails";
            public static string SelectThisBranchDetails = "SelectThisBranchDetails";
            
            public static string SelectAllCityDetails = "SelectAllCityDetails";
            public static string SelectThisCityDetails = "SelectThisCityDetails";
            public static string SelectAllActiveCityDetails = "SelectAllActiveCityDetails";

            public static string SelectAllDesignationSlotDetails = "SelectAllDesignationSlotDetails";
            public static string SelectThisDesignationSlotDetails = "SelectThisDesignationSlotDetails";
            public static string SelectAllReportingDesignationSlotDetails = "SelectAllReportingDesignationSlotDetails";

            public static string SelectThisNationalityDetails = "SelectThisNationalityDetails";
            public static string SelectAllNationalityDetails = "SelectAllNationalityDetails";

            public static string FO_selectThisFO_RemindMethods = "FO_selectThisFO_RemindMethods";
            public static string FO_SelectAllFO_RemindMethods = "FO_SelectAllFO_RemindMethods";

            public static string FO_SelectAllSeasonCategoryDetails = "FO_SelectAllFO_SeasonCategories";
            public static string FO_SelectthisSeasonCategoryDetails = "FO_selectThisFO_SeasonCategories";
            public static string FO_selectThisFO_SeasonCategoriesByID = "FO_selectThisFO_SeasonCategoriesByID";

            public static string FO_SelectAllRoomTypeDetails = "FO_SelectAllFO_RoomTypeDetails";
            public static string FO_SelectthisRoomTypeDetails = "FO_SelectthisRoomTypeDetails";

            public static string FO_SelectAllFO_RateCodeWiseRoomType = "FO_SelectAllFO_RateCodeWiseRoomType";

            public static string GEN_SelectAllMainMenu = "GEN_SelectAllGen_MainMenu";
            public static string selectAllGen_SubMenuLevel1 = "GEN_SelectAllGen_SubMenuLevel1";
            public static string selectAllGen_SubMenuLevel2 = "GEN_SelectAllGen_SubMenuLevel2";
            public static string selectAllGen_SubMenuLevel3 = "GEN_SelectAllGen_SubMenuLevel3";

            public static string GEN_SelectAllCurrencyDetails = "GEN_SelectAllCurrencyDetails";
            public static string GEN_SelectthisCurrencyDetails = "GEN_SelectthisCurrencyDetails";

            public static string GEN_SelectAllTableSetupDetails = "GEN_SelectAllGEN_TableCodeSetUp";
            public static string GEN_SelectthisTableSetupDetails = "GEN_selectThisGEN_TableCodeSetUp";

            public static string GEN_SelectAllGEN_HotelDetails = "GEN_SelectAllGEN_HotelDetails";
            public static string GEN_SelectthisGEN_HotelDetails = "GEN_SelectthisGEN_HotelDetails";

            public static string GEN_SelectAllRegionDetails = "GEN_SelectAllRegionDetails";
            public static string GEN_SelectThisRegionDetails = "GEN_SelectThisRegionDetails";

            public static string FO_SelectAllRoomAreaDetails = "FO_SelectAllRoomAreaDetails";
            public static string FO_SelectThisRoomAreaDetails = "FO_SelectThisRoomAreaDetails";

            //public static string FO_SelectAllRoomResourcesDetails = "FO_SelectAllRoomResourcesDetails";
            //public static string FO_SelectthisRoomResourcesDetails = "FO_SelectthisRoomResourcesDetails";

            public static string selectThisFO_Nationality = "FO_selectThisFO_Nationality";
            public static string selectAllFO_Nationality = "FO_selectAllFO_Nationality";

            public static string SelectAllUserDetails = "SelectAllUserDetails";
            public static string selectThisUserDetails = "SelectThisUserDetails";
            public static string SelectEmployeeFromUserId = "SelectEmployeeFromUserId";
            public static string selectThisUserAccess = "select_userAccess";
            public static string selectAllWebAccess = "selectAllWebAccess";
            public static string selectThisWebAccess = "selectThisWebAccess";
            public static string selectThisWebUser = "selectThisWebUser";

            //FO_selectThisFO_WaitListedReservations
            public static string FO_selectThisFO_WaitListedReservations = "FO_selectThisFO_WaitListedReservations";

            public static string FO_selectAllFO_AirLineDetails = "FO_selectAllFO_AirLineDetails";
            public static string FO_selectThisFO_AirLineDetails = "FO_selectThisFO_AirLineDetails";

            public static string FO_selectAllFO_AirPortDetails = "FO_selectAllFO_AirPortDetails";
            public static string FO_selectThisFO_AirPortDetails = "FO_selectThisFO_AirPortDetails";

            public static string FO_selectThisFO_TelephoneRateTypes = "FO_selectThisFO_TelephoneRateTypes";
            public static string FO_SelectAllFO_TelephoneRateTypes = "FO_SelectAllFO_TelephoneRateTypes";

            public static string FO_selectAllFO_ArrivalLocation = "FO_selectAllFO_ArrivalLocation";
            public static string FO_selectThisFO_ArrivalLocation = "FO_selectThisFO_ArrivalLocation";

            public static string FO_selectAllFO_ArrivalModeDetails = "FO_SelectAllFO_ArrivalModeDetails";
            public static string FO_selectThisFO_ArrivalModeDetails = "FO_SelectThisFO_ArrivalModeDetails";

            public static string selectAllFO_ConfirmationMethords = "FO_SelectAllFO_ConfirmationMethords";
            public static string selectThisFO_ConfirmationMethords = "FO_selectThisFO_ConfirmationMethords";
            public static string selectAllFO_GuestComplainTypes = "FO_selectAllFO_GuestComplainTypes";
            public static string selectThisFO_GuestComplainTypes = "FO_selectThisFO_GuestComplainTypes";

            //FO_SelectFO_ReminderTypes
            public static string FO_SelectFO_ReminderTypes = "FO_SelectFO_ReminderTypes";

            // Telephone monitoring 
            public static string FO_selectAllFO_TelephoneLines = "FO_selectAllFO_TelephoneLines";
            public static string FO_selectThisFO_TelephoneLines = "FO_selectThisFO_TelephoneLines";

            public static string FO_selectThisFO_TelephoneNumberDetails = "FO_selectThis_FO_TelephoneNumberDetails";
            public static string FO_selectAllFO_TelephoneNumberDetails = "FO_selectAll_FO_TelephoneNumberDetails";
            
            public static string FO_SelectAllFO_TeleponeExtentionGroups = "FO_SelectAllFO_TeleponeExtentionGroups";
            public static string FO_selectThisFO_TeleponeExtentionGroups = "FO_selectThisFO_TeleponeExtentionGroups";
            public static string selectAllFO_GuestStatusDetails = "fo_selectAllFO_GuestStatusDetails";
            public static string selectThisFO_GuestStatusDetails = "FO_selectThisFO_GuestStatusDetails";
            public static string selectAllFO_NameTitleDetails = "FO_selectAllFO_NameTitleDetails";
            public static string FO_SelectOnlyActiveAllFO_NameTitleDetails = "FO_SelectOnlyActiveAllFO_NameTitleDetails";

            public static string selectThisFO_NameTitleDetails = "FO_selectThisFO_NameTitleDetails";
            public static string selectAllFO_OutOfOrderReasones = "FO_selectAllFO_OutOfOrderReasones";
            public static string selectThisFO_OutOfOrderReasones = "FO_selectThisFO_OutOfOrderReasones";
            public static string selectThisFO_VisitPurposeDetails = "FO_selectThisFO_VisitPurposeDetails";
            public static string selectAllFO_ReservationStatus = "FO_selectAllFO_ReservationStatus";
            public static string selectThisFO_ReservationStatus = "FO_selectThisFO_ReservationStatus";
            public static string selectAllFO_VisitPurposeDetails = "FO_selectAllFO_VisitPurposeDetails";
            public static string selectAllFO_RoomAreaDetails = "FO_selectAllFO_RoomAreaDetails";
            public static string selectThisFO_RoomAreaDetails = "FO_selectThisFO_RoomAreaDetails";
            public static string selectAllFO_RoomAreaDetailsByHotelID = "FO_SelectAllFO_RoomAreaDetailsByHotelID";

            //Terminals
            public static string selectAllFO_Terminals = "FO_SelectAllFO_Terminals";
            public static string selectThisFO_Terminals = "FO_selectThisFO_Terminals";

            public static string selectAllFO_TourOperatorDetails = "FO_SelectAllFO_TourOperatorDetails";
            public static string selectThisFO_TourOperatorDetails = "FO_selectThisFO_TourOperatorDetails";

            public static string selectAllQueryFO_TourOperatorDetails = "FO_SelectAllQueryFO_TourOperatorDetails";

            public static string selectAllGEN_CountryDetails = "FO_SelectAllGEN_CountryDetails";
            public static string selectThisGEN_CountryDetails = "FO_selectThisGEN_CountryDetails";

            //FO_SelectAllFO_ArrivalMeals
            public static string FO_SelectAllFO_ArrivalMeals = "FO_SelectAllFO_ArrivalMeals";

            //FO_SelectAllFO_CancelReservations
            public static string FO_SelectAllFO_CancelReservations = "FO_SelectAllFO_CancelReservations";
            public static string FO_selectThisFO_CancelReservations = "FO_selectThisFO_CancelReservations";

            //FO_selectThisFO_RoomReservationHeader
            public static string FO_selectThisFO_RoomReservationHeader = "FO_selectThisFO_RoomReservationHeader";
            public static string FO_SelectAllFO_RoomReservationHeader = "FO_SelectAllFO_RoomReservationHeader";
            public static string FO_selectThisFO_RoomReservationHeaderByArrivalDate = "FO_selectThisFO_RoomReservationHeaderByArrivalDate";
            public static string FO_SelectAllFO_RoomReservationHeaderByHeaderID = "FO_SelectAllFO_RoomReservationHeaderByHeaderID";

            //FO_selectThisFO_RoomReservationDetailByArrivalDate
            public static string FO_selectThisFO_RoomReservationDetailByArrivalDate = "FO_selectThisFO_RoomReservationDetailByArrivalDate";
            public static string FO_selectThisFO_RoomReservationDetailByHeaderID = "FO_selectThisFO_RoomReservationDetailByHeaderID";

            //TracesNeeds
            public static string FO_SelectAllFO_TracesDetails = "FO_SelectAllFO_TracesDetails";
            public static string FO_SelectThisFO_TracesDetails = "FO_SelectThisFO_TracesDetails";

            //Segment Details
            public static string FO_SelectAllFO_SegmentDetails = "FO_SelectAllFO_SegmentDetails";
            public static string FO_selectThisFO_SegmentDetails = "FO_selectThisFO_SegmentDetails";

            //Rate Code
            public static string FO_SelectAllFO_RateCode = "FO_SelectAllFO_RateCode";
            public static string FO_SelectThisFO_RateCode = "FO_SelectThisFO_RateCode";

            //[FO_SelectAllFO_RateCodeHeader]
            public static string FO_SelectAllFO_RateCodeHeader="FO_SelectAllFO_RateCodeHeader";

            //FO_SelectAllFO_RateCodeWiseRoomCategory
            public static string FO_SelectAllFO_RateCodeWiseRoomCategory = "FO_SelectAllFO_RateCodeWiseRoomCategory";

            //FO_SelectAllFO_RoomSharesDetails
            public static string FO_SelectAllFO_RoomSharesDetails = "FO_SelectAllFO_RoomSharesDetails";
            public static string FO_selectThisFO_RoomSharesDetails = "FO_selectThisFO_RoomSharesDetails";
            public static string FO_selectThisFO_RoomSharesDetailsByReservationHeaderID = "FO_selectThisFO_RoomSharesDetailsByReservationHeaderID";

            //Rate Code Header
            public static string FO_SelectThisFO_RateCodeHeader="FO_SelectThisFO_RateCodeHeader";
            public static string FO_SelectThisIDFO_RateCodeHeader = "FO_SelectThisIDFO_RateCodeHeader";

            //Package Details
            public static string FO_SelectAllFO_PackageDetails = "FO_SelectAllFO_PackageDetails";
            public static string FO_SelectThisFO_PackageDetails = "FO_SelectThisFO_PackageDetails";

            //FO_RateCategory
            public static string FO_selectThisFO_RateCategory = "FO_selectThisFO_RateCategory";
            public static string FO_SelectAllFO_RateCategory = "FO_SelectAllFO_RateCategory";

            //FO_MarketCategory
            public static string FO_selectThisFO_MarketCategory = "FO_selectThisFO_MarketCategory";
            public static string FO_SelectAllFO_MarketCategory = "FO_SelectAllFO_MarketCategory";

            //FO_SourceCategory
            public static string FO_selectThisFO_SourceCategory = "FO_selectThisFO_SourceCategory";
            public static string FO_SelectAllFO_SourceCategory = "FO_SelectAllFO_SourceCategory";

            //FO_SelectAllFO_RoomReservationDates
            public static string FO_SelectAllFO_RoomReservationDates = "FO_SelectAllFO_RoomReservationDates";
            public static string FO_SelectAllFO_RoomReservationDatesDetails = "FO_SelectAllFO_RoomReservationDatesDetails";
            public static string FO_SelectAllFO_RoomReservationDatesSelectAll="FO_SelectAllFO_RoomReservationDatesSelectAll";

            //FO_Market
            public static string FO_selectThisFO_Market = "FO_selectThisFO_Market";
            public static string FO_SelectAllFO_Market = "FO_SelectAllFO_Market";

            //FO_SelectAllFO_RoomAdditionalDetails
            public static string FO_SelectAllFO_RoomAdditionalDetails = "FO_SelectAllFO_RoomAdditionalDetails";
            public static string FO_selectThisFO_RoomAdditionalDetails = "FO_selectThisFO_RoomAdditionalDetails";

            //FO_selectThisFO_TransferTypes
            public static string FO_selectThisFO_TransferTypes = "FO_selectThisFO_TransferTypes";

            //FO_SelectAllFO_TransferTypes
            public static string FO_SelectAllFO_TransferTypes = "FO_SelectAllFO_TransferTypes";

            //FO_SelectAll_Settings
            public static string SelectAllSettings = "SelectAllSettings";
            public static string Select_ALL_Settings = "Select_ALL_Settings";
            public static string SelectAllSettingsMainMenu = "SelectAllSettingsMainMenu";
            public static string SelectAllSettingsByOrderId = "SelectAllSettingsByOrderId";
            public static string SelectAllSettingsByOrderIdMenuLevel2 = "SelectAllSettingsByOrderIdMenuLevel2";
            public static string SelectAllSettingsByOrderIdMenuLevel3 = "SelectAllSettingsByOrderIdMenuLevel3";

            //FO_SelectAllFO_GuestProfile
            public static string FO_SelectAllFO_GuestProfile = "FO_SelectAllFO_GuestProfile";
            public static string FO_SelectAllFO_GuestProfileByNames="FO_SelectAllFO_GuestProfileByNames";
            public static string FO_SelectAllFO_GuestProfileSelectByName = "FO_SelectAllFO_GuestProfileSelectByName";
            public static string FO_SelectAllFO_GuestProfileSelectByType = "FO_SelectAllFO_GuestProfileSelectByType";
            public static string FO_SelectAllFO_GuestProfileFilter = "FO_SelectAllFO_GuestProfileFilter";

            //FO_SelectFO_ReservationPaymentModes
            public static string FO_SelectFO_ReservationPaymentModes = "FO_SelectFO_ReservationPaymentModes";

            //FO_Source
            public static string FO_selectThisFO_Source = "FO_selectThisFO_Source";
            public static string FO_SelectAllFO_Source = "FO_SelectAllFO_Source";

            //FO_selectThisFO_Transfers
            public static string FO_selectThisFO_Transfers = "FO_selectThisFO_Transfers";

            //FO_ReservationTypes
            public static string FO_SelectAllFO_ReservationTypes = "FO_SelectAllFO_ReservationTypes";
            public static string FO_selectThisFO_ReservationTypes = "FO_selectThisFO_ReservationTypes";

            //FO_LanguageDetails
            public static string FO_selectThisFO_LanguageDetails = "FO_selectThisFO_LanguageDetails";
            public static string FO_SelectAllFO_LanguageDetails = "FO_SelectAllFO_LanguageDetails";

            //FO_VIPDetails
            public static string FO_SelectAllFO_VIPDetails = "FO_SelectAllFO_VIPDetails";
            public static string FO_selectThisFO_VIPDetails = "FO_selectThisFO_VIPDetails";

            //FO_InterestDetails
            public static string FO_SelectAllFO_InterestDetails = "FO_SelectAllFO_InterestDetails";
            public static string FO_selectThisFO_InterestDetails = "FO_selectThisFO_InterestDetails";

            //FO_Designations
            public static string FO_SelectAllFO_Designations = "FO_SelectAllFO_Designations";

            //FO_GuestProfileStatus
            public static string FO_SelectAllFO_GuestProfileStatus="FO_SelectAllFO_GuestProfileStatus";

            //FO_Designations
            public static string FO_SelectThisFO_Designations="FO_SelectThisFO_Designations";

            //FO_SelectAllFO_MasterResNo
            public static string FO_SelectAllFO_MasterResNo = "FO_SelectAllFO_MasterResNo";


            #region Select's MealPlan Details
            //MealPlan Details
            public static string FO_SelectAllFO_MealPlanDetails = "FO_SelectAllFO_MealPlanDetails";
            public static string FO_selectThisFO_MealPlanDetails = "FO_selectThisFO_MealPlanDetails";
            #endregion

            #region Select's MealTime Details
            //MealTime Details
            public static string FO_SelectAllFO_MealTimes = "FO_SelectAllFO_MealTimes";
            #endregion

            #region Select's Room Category Details 
            //Room Category Details
            public static string FO_SelectAllFO_RoomCategories = "FO_SelectAllFO_RoomCategories";
            public static string FO_selectThisFO_RoomCategories = "FO_selectThisFO_RoomCategories";
            #endregion

            #region Select's Room Resource Details
            //Room Resource Details
            public static string FO_SelectAllFO_RoomResourceDetails = "FO_SelectAllFO_RoomResourceDetails";
            public static string FO_selectThisFO_RoomResourceDetails = "FO_selectThisFO_RoomResourceDetails";
            #endregion

            #region Select's Room Details
            //Room  Details
            public static string FO_SelectAllFO_RoomDetails = "FO_SelectAllFO_RoomDetails";
            public static string FO_SelectOnlyActiveAllFO_RoomDetails = "FO_SelectOnlyActiveAllFO_RoomDetails";
            public static string FO_selectThisFO_RoomDetails = "FO_selectThisFO_RoomDetails";
            #endregion

            //Hotel Wise Segment Details
            public static string FO_SelectAllFO_HotelWiseSegmentDetails = "FO_SelectAllFO_HotelWiseSegmentDetails";
            public static string FO_SelectThisFO_HotelWiseSegmentDetails = "FO_SelectThisFO_HotelWiseSegmentDetails";

            //Hotel Wise Package Details
            public static string FO_SelectAllFO_HotelWisePackageDetails = "FO_SelectAllFO_HotelWisePackageDetails";
            public static string FO_SelectThisFO_HotelWisePackageDetails = "FO_SelectThisFO_HotelWisePackageDetails";

            //Hotel Wise Rate Code Details
            public static string FO_SelectAllFO_HotelWiseRateCodeDetails = "FO_SelectAllFO_HotelWiseRateCodeDetails";
            public static string FO_SelectThisFO_HotelWiseRateCodeDetails = "FO_SelectThisFO_HotelWiseRateCodeDetails";

            //FO_SelectAllFO_RoomReservationDetail
            public static string FO_SelectAllFO_RoomReservationDetail = "FO_SelectAllFO_RoomReservationDetail";

            //Hotel Wise Room Rate Types Details
            public static string FO_SelectAllFO_HotelWiseRoomRateTypesDetails = "FO_SelectAllFO_HotelWiseRoomRateTypesDetails";
            public static string FO_SelectThisFO_HotelWiseRoomRateTypesDetails = "FO_SelectThisFO_HotelWiseRoomRateTypesDetails";

            //Bed Type Details
            public static string FO_SelectAllFO_BedTypeDetails = "FO_SelectAllFO_BedTypeDetails";
            public static string FO_selectThisFO_BedTypeDetails = "FO_selectThisFO_BedTypeDetails";

            //Hotel Wise Market Details
            public static string FO_SelectAllFO_HotelWiseMarketDetails = "FO_SelectAllFO_HotelWiseMarketDetails";
            public static string FO_SelectThisFO_HotelWiseMarketDetails = "FO_SelectThisFO_HotelWiseMarketDetails";

            //RoomRateTypeDetails
            public static string selectAllFO_FO_RoomRateTypeDetails = "FO_SelectAllFO_RoomRateTypeDetails";
            public static string selectThisFO_FO_RoomRateTypeDetails = "FO_selectThisFO_RoomRateTypeDetails";

            //Hotel wise Season Category
            public static string selectAllFO_FO_HotelwiseSeasonCategory = "selectAllFO_FO_HotelwiseSeasonCategory";
            public static string selectThisFO_FO_HotelwiseSeasonCategory = "selectThisFO_FO_HotelwiseSeasonCategory";

            public static string selectAllFO_CustomerAttributes = "FO_SelectThisFO_CustomerAttributs";


            //Market Details
            public static string FO_SelectAllFO_MarketDetails = "FO_SelectAllFO_MarketDetails";
            public static string FO_SelectThisFO_MarketDetails = "FO_SelectThisFO_MarketDetails";


            //FO_RhythmDetails
            public static string FO_SelectAllFO_RhythmDetails = "FO_SelectAllFO_RhythmDetails";


            #region Select HotelWise Room Category Details
            //Hotel Wise Room Category Details
            public static string FO_SelectAllFO_HotelWiseRoomCategoryDetails = "FO_SelectAllFO_HotelWiseRoomCategoryDetails";
            public static string FO_SelectThisFO_HotelWiseRoomCategoryDetails = "FO_SelectThisFO_HotelWiseRoomCategoryDetails";
            #endregion

            #region Select HotelWise Room Category Resources
            //Hotel Wise Room Category Resources
            public static string FO_SelectAllFO_HotelWiseRoomCategoryResources = "FO_SelectAllFO_HotelWiseRoomCategoryResources";
            public static string FO_SelectThisFO_HotelWiseRoomCategoryResources = "FO_SelectThisFO_HotelWiseRoomCategoryResources";
            public static string FO_SelectAllFO_RoomCategoryDetailsByHotelID = "FO_SelectAllFO_RoomCategoryDetailsByHotelID";
            public static string selectAllFO_CustomerMaster = "FO_selectAllFO_CustomerMaster";
            public static string selectThisFO_CustomerMaster = "FO_selectThisFO_CustomerMaster";
            public static string selectThisFO_CancellationPolicy = "FO_selectThisFO_CancellationPolicy";
            public static string selectAllFO_CancellationPolicy = "FO_selectAllFO_CancellationPolicy";
            public static string FO_selectThisFO_CustomerMasterCode = "FO_selectThisFO_CustomerMasterCode";
            public static string FO_selectThisFO_CustomerMaster = "FO_selectThisFO_CustomerMaster";
            
            #endregion

            // Room Rates 
            public static string FO_SelectThisFO_RoomRateDetails = "FO_SelectThisFO_RoomRateDetails";


            //Void Reasons
            public static string FO_SelectAllFO_VoidReasons = "FO_SelectAllFO_VoidReasons";
            public static string FO_SelectThisFO_VoidReasons = "FO_SelectThisFO_VoidReasons";

            //MiscBillCategory
            public static string FO_SelectAllFO_MiscBillCategory = "FO_SelectAllFO_MiscBillCategory";
            public static string FO_SelectThisFO_MiscBillCategory = "FO_SelectThisFO_MiscBillCategory";
            public static string selectThisFO_MealReservationMealType = "FO_selectThisFO_MealReservationMealType";
            public static string selectAllFO_MealReservationMealType = "FO_selectAllFO_MealReservationMealType";

            //MiscBillTypes
            public static string FO_SelectAllFO_MiscBillTypes = "FO_SelectAllFO_MiscBillTypes";
            public static string FO_SelectThisFO_MiscBillTypes = "FO_SelectThisFO_MiscBillTypes";

            //Misc Module Category
            public static string FO_SelectAllFO_MiscModuleCategory = "FO_SelectAllFO_MiscModuleCategory";
            public static string FO_SelectThisFO_MiscModuleCategory = "FO_SelectThisFO_MiscModuleCategory";


            public static string FO_CheckThisFO_MealReservationMealType = "FO_CheckThisFO_MealReservationMealType";

            public static string FO_selectAllFO_StaffWiseInterfaceIDDetails = "FO_selectAllFO_StaffWiseInterfaceIDDetails";
            public static string FO_selectThisFO_StaffWiseInterfaceIDDetails = "FO_selectThisFO_StaffWiseInterfaceIDDetails";


            //Misc Module Item Categories
            public static string FO_SelectThisFO_MiscModuleItemCategories = "FO_SelectThisFO_MiscModuleItemCategories";
            public static string FO_SelectAllFO_MiscModuleItemCategories = "FO_SelectAllFO_MiscModuleItemCategories";

            //MiscModuleCategoriesItem
            public static string FO_SelectAllFO_MiscModuleCategoriesItem = "FO_SelectAllFO_MiscModuleCategoriesItem";
            public static string FO_SelectThisFO_MiscModuleCategoriesItem = "FO_SelectThisFO_MiscModuleCategoriesItem";

            //GEN_Country Details

            public static string FO_SelectAllGEN_CountryDetails = "FO_SelectAllGEN_CountryDetails";
            public static string FO_selectThisGEN_CountryDetails = "FO_selectThisGEN_CountryDetails";

            //FO_CommunicationTypes
            public static string FO_SelectAllFO_CommunicationTypes = "FO_SelectAllFO_CommunicationTypes";
            public static string FO_SelectAllOnlyActiveFO_CommunicationTypes = "FO_SelectAllOnlyActiveFO_CommunicationTypes";
            public static string FO_selectThisFO_CommunicationTypes = "FO_selectThisFO_CommunicationTypes";

            //FO_TransactionCodes
            public static string FO_SelectAllFO_TransactionCodes = "FO_SelectAllFO_TransactionCodes";
            public static string FO_selectThisFO_TransactionCodes = "FO_selectThisFO_TransactionCodes";
            public static string FO_SelectAllFO_RateCodeWiseTransaction = "FO_SelectAllFO_RateCodeWiseTransaction";


            //FO_RateCodeDetail
            public static string FO_SelectAllFO_RateCodeDetail = "FO_SelectAllFO_RateCodeDetail";
            public static string FO_selectThisFO_RateCodeDetail = "FO_selectThisFO_RateCodeDetail";
            public static string FO_SelectThisByFromAndToDatesFO_RateCodeDetail = "FO_SelectThisByFromAndToDatesFO_RateCodeDetail";

            //FO_CommentArea
            public static string FO_selectThisFO_CommentArea = "FO_selectThisFO_CommentArea";
            public static string FO_SelectAllFO_CommentArea = "FO_SelectAllFO_CommentArea";

            //FO_SelectAllFO_ReservationCancellationReasons
            public static string FO_SelectAllFO_ReservationCancellationReasons = "FO_SelectAllFO_ReservationCancellationReasons";
            public static string FO_selectThisFO_ReservationCancellationReasons = "FO_selectThisFO_ReservationCancellationReasons";

            //FO_CommissionTypes
            public static string FO_SelectAllFO_CommissionTypes = "FO_SelectAllFO_CommissionTypes";
            public static string FO_selectThisFO_CommissionTypes = "FO_selectThisFO_CommissionTypes";

            //FO_SelectAllFO_WaitListedReasons
            public static string FO_SelectAllFO_WaitListedReasons = "FO_SelectAllFO_WaitListedReasons";
            public static string FO_selectThisFO_WaitListedReasons = "FO_selectThisFO_WaitListedReasons";

            //FO_SelectAllFO_PriorityDetails
            public static string FO_SelectAllFO_PriorityDetails = "FO_SelectAllFO_PriorityDetails";
            public static string FO_selectThisFO_PriorityDetails = "FO_selectThisFO_PriorityDetails";

            //GEN_DepartmentDetails
            public static string GEN_SelectAllGEN_DepartmentDetails = "GEN_SelectAllGEN_DepartmentDetails";
            public static string GEN_SelectThisGEN_DepartmentDetails = "GEN_SelectThisGEN_DepartmentDetails";

            //FO_SelectAllFO_RateCodeAttributes
            public static string FO_SelectAllFO_RateCodeAttributes = "FO_SelectAllFO_RateCodeAttributes";

            //FO_RateCodeRates
            public static string FO_SelectAllFO_RateCodeRates="FO_SelectAllFO_RateCodeRates";

            //FO_SelectAllFO_RateCodeWiseTransactionAndMealPlan
            public static string FO_SelectAllFO_RateCodeWiseTransactionAndMealPlan="FO_SelectAllFO_RateCodeWiseTransactionAndMealPlan";
            public static string FO_SelectthisAllFO_RateCodeRates = "FO_SelectthisAllFO_RateCodeRates";
            
            //FO_SelectByDetailID_FO_RateCodeRatesChild
            public static string FO_SelectByDetailID_FO_RateCodeRatesChild = "FO_SelectByDetailID_FO_RateCodeRatesChild";

            //FO_ChildStructure
            public static string FO_SelectAllFO_ChildStructure="FO_SelectAllFO_ChildStructure";

            //FO_SelectAllFO_HouseKeepingStatusDetail
            public static string FO_SelectAllFO_HouseKeepingStatusDetail = "FO_SelectAllFO_HouseKeepingStatusDetail";

            //FO_SelectAllFO_RateCodeWiseMealPlanDetails
            public static string FO_SelectAllFO_RateCodeWiseMealPlanDetails="FO_SelectAllFO_RateCodeWiseMealPlanDetails";

            //FO_SelectAllFO_RateCodeWiseRateCodeDetail
            public static string FO_SelectAllFO_RateCodeWiseRateCodeDetail="FO_SelectAllFO_RateCodeWiseRateCodeDetail";

            //FO_SelectAllFO_RateCodeWisePackage
            public static string FO_SelectAllFO_RateCodeWisePackage="FO_SelectAllFO_RateCodeWisePackage";

            //FO_SelectAllFO_RateCodeWiseAttributes
            public static string FO_SelectAllFO_RateCodeWiseAttributes = "FO_SelectAllFO_RateCodeWiseAttributes";

            //FO_SelectAllFO_RoomInventoryItems
            public static string FO_SelectAllFO_RoomInventoryItems = "FO_SelectAllFO_RoomInventoryItems";
            public static string FO_SelectThisFO_RoomInventoryItems = "FO_SelectThisFO_RoomInventoryItems";

            //FO_SelectAllFO_GuestRequest
            public static string FO_SelectAllFO_GuestRequest = "FO_SelectAllFO_GuestRequest";
            public static string FO_SelectThisFO_GuestRequest = "FO_SelectThisFO_GuestRequest";

            //Designation Details
            public static string SelectAllDesignationDetails = "SelectAllDesignationDetails";
            public static string SelectThisDesignationDetails = "selectThisDesignationDetails";

            //Level Details
            public static string SelectAllLevelDetails = "SelectAllLevelDetails";
            public static string SelectThisLevelDetails = "selectThisLevelDetails";

            //Grade Details
            public static string SelectAllGradeDetails = "SelectAllGradeDetails";
            public static string SelectThisByGradeName = "SelectThisGradeDetails";

            //Company Details
            public static string SelectAllCompanyDetails = "SelectAllCompanyDetails";
            public static string SelectThisCompanyDetails = "SelectThisCompanyDetails";
            public static string SelectThisCompanyDetailsByCompanyId = "SelectThisCompanyDetailsByCompanyId";

            //Salary Band Details
            public static string SelectAllSalaryBandDetails = "SelectAllSalaryBandDetails";
            public static string SelectThisSalaryBandDetails = "SelectThisSalaryBandDetails";

            //CompanyWiseLevelDetails
            public static string SelectAllCompanyWiseLevelDetails = "SelectAllCompanyWiseLevelDetails";
            public static string SelectThisCompanyWiseLevelDetails = "SelectThisCompanyWiseLevelDetails";

            //Race Details
            public static string SelectAllRaceDetails = "SelectAllRaceDetails";
            public static string SelectThisRaceDetails = "SelectThisRaceDetails";

            //Religion Details
            public static string SelectAllReligionDetails = "SelectAllReligionDetails";
            public static string SelectThisReligionDetails = "SelectThisReligionDetails";

            //Province Details
            public static string SelectAllProvinceDetails = "SelectAllProvinceDetails";
            public static string SelectThisProvinceDetails = "SelectThisProvinceDetails";

            //District Details
            public static string SelectAllDistrictDetails = "SelectAllDistrictDetails";
            public static string SelectThisDistrictDetails = "SelectThisDistrictDetails";

            //Cost Center Details
            public static string SelectAllCostCenterDetails = "SelectAllCostCenterDetails";
            public static string SelectThisCostCenterDetails = "SelectThisCostCenterDetails";

            //Employee Status Details
            public static string SelectAllEmployeeStatusDetails = "SelectAllEmployeeStatusDetails";
            public static string SelectThisEmployeeStatusDetails = "SelectThisEmployeeStatusDetails";

            //Education Level Details
            public static string SelectAllEducationLevelDetails = "SelectAllEducationLevelDetails";
            public static string SelectThisEducationLevelDetails = "SelectThisEducationLevelDetails";
            public static string SelectAllActiveEducationLevelDetails = "SelectAllActiveEducationLevelDetails";

            //Classification Header Details
            public static string SelectAllClassificationHeaderDetails = "SelectAllClassificationHeaderDetails";
            public static string SelectThisClassificationHeaderDetails = "SelectThisClassificationHeaderDetails";

            //Employee Details
            public static string SelectAllEmployeeDetails = "SelectAllEmployeeDetails";
            public static string SelectAllActiveEmployeeDetails = "SelectAllActiveEmployeeDetails";
            public static string SelectThisEmployeeDetails = "SelectThisEmployeeDetails";
            public static string SelectThisEmployeeDetailsByEmployeeId = "SelectThisEmployeeDetailsByEmployeeId";
            public static string SelectAllCurrentDesignationFromEmployee = "SelectAllCurrentDesignationFromEmployee";
            public static string SelectEmployeesWhoHasPromotionAllowPermissions = "SelectEmployeesWhoHasPromotionAllowPermissions";
            public static string SelectAllEmployeeWiseStatusForProcess = "SelectAllEmployeeWiseStatusForProcess";
            public static string rptSelectThisEmployeeDetails = "rpt_SelectThisEmployeeDetails"; // for report
            public static string SelectThisEmployeeDetailsByEmployeeIdForReport = "SelectThisEmployeeDetailsByEmployeeIdForReport"; // User Profile Report

            //Employee Wise Helth Profile Details
            public static string SelectAllEmployeeWiseHelthProfile = "SelectAllEmployeeWiseHelthProfileDetails";
            public static string SelectThisEmployeeWiseHelthProfile = "SelectThisEmployeeWiseProfileDetails";
            public static string SelectAllEmployeeWiseHealthProfileDetails = "SelectAllEmployeeWiseHealthProfileDetails";

            //Employee Wise Qualification Details
            public static string SelectAllEmployeeWiseQualificationDetails = "SelectAllEmployeeWiseQualificationsDetail";
            public static string SelectThisEmployeeWiseQualificationsDetailByEmpId = "SelectThisEmployeeWiseQualificationsDetailByEmpId";

            //Employee Wise Achievement Details
            public static string SelectAllEmployeeWiseAchievementDetails = "SelectAllEmployeeWiseAchievementDetail";
            public static string SelectThisEmployeeWiseAchievementDetailByEmployeeId = "SelectThisEmployeeWiseAchievementDetailByEmployeeId";


            //Designation Wise Leave Type
            public static string SelectAllDesignationWiseLeaveTypeDetails = "SelectAllDesignationWiseLeaveType";
            public static string SelectThisDesignationWiseLeaveTypeDetails = "SelectThisDesignationWiseLeaveType";
            public static string SelectAllLeaveTypeDetailsAcordingToEmployeeDesignation = "SelectAllLeaveTypeDetailsAcordingToEmployeeDesignation";

            
            //Employee Wise Leave Type
            public static string SelectThisEmployeeWiseLeaveTypesDetails = "SelectThisEmployeeWiseLeaveTypesDetails";
            public static string SelectAllEmployeeWiseLeaveTypesDetails = "SelectAllEmployeeWiseLeaveTypesDetails";
            public static string SelectThisEmployeeWiseLeaveTypesDetailsByEmployeeId = "SelectThisEmployeeWiseLeaveTypesDetailsByEmployeeId";

            //Employee Wise Reference Details
            public static string SelectAllEmployeeWiseReferenceDetails = "SelectAllEmployeeWiseReferenceDetails";

            //Select All Employee Reference No Details
            public static string SelectAllEmployeeReferenceNoDetails = "SelectAllEmployeeReferenceNoDetails";
            public static string SelectThisEmployeeWiseReferenceDetails = "SelectThisEmployeeWiseReferenceDetails";
            public static string SelectThisEmployeeWiseReferenceDetailsByEmployeeId = "SelectThisEmployeeWiseReferenceDetailsByEmployeeId";

            //Select All Address Type Details
            public static string SelectAllAddressTypeDetails = "SelectAllAddressTypeDetails";

            //Assets Inventory Details
            public static string SelectAllAssetsInventoryDetails = "SelectAllAssetsInventoryDetails";
            public static string SelectThisAssetsInventoryDetails = "SelectThisAssetsInventoryDetails";

            //Promotion Designation Approval Level Details
            public static string SelectAllPromotionDesignationApprovalLevelDetails = "SelectAllPromotionDesignationApprovalLevelDetails";
            public static string SelectThisPromotionDesignationApprovalLevelDetails = "SelectThisPromotionDesignationApprovalLevelDetails";
            public static string SelectAllPromotionDesignationApprovalLevelDetailsForCombo = "SelectAllPromotionDesignationApprovalLevelDetailsForCombo";
            public static string SelectAllDesignationDetailsByLevel = "SelectAllDesignationDetailsByLevel";


            //Employee Wise Benifit Details--------------------------------
            public static string SelectAllEmployeeWiseBenifitDetails = "SelectAllEmployeeWiseBenifitDetails";
            public static string SelectThisEmployeeWiseBenifitDetails = "SelectThisEmployeeWiseBenifitDetails";
            public static string SelectAllEmployeeNamesInEmployeeWiseBenifitDetails = "SelectAllEmployeeNamesInEmployeeWiseBenifitDetails";
            public static string SelectAllDistinctEmployeeWiseBenifitDetails = "SelectAllDistinctEmployeeWiseBenifitDetails";
            public static string rptSelectThisBenifitDetails = "rpt_SelectThisBenifitDetails";// for report 


            //Select All Menu Levels
            public static string SelectAllMenuLevel = "SelectAllMenuLevel";

            public static string SelectAllUserAccess = "SelectAllUserAccess";

            public static string SelectUploadImageData = "SelectUploadImageData";

            //Company Wise Leave Units
            public static string SelectAllCompanyWiseLeaveUnits = "SelectAllCompanyWiseLeaveUnits";
            public static string SelectThisCompanyWiseLeaveUnits = "SelectThisCompanyWiseLeaveUnits";
            public static string SelectThisCompanyWiseLeaveUnitsByLeaveUnit = "SelectThisCompanyWiseLeaveUnitsByLeaveUnit";

            //Leave Request
            public static string SelectAllLeaveRequest = "SelectAllLeaveRequest";
            public static string SelectThisLeaveRequest = "SelectThisLeaveRequest";

            //Outstation Allowance
            public static string SelectAllOutstationAllowance = "SelectAllOutstationAllowance";
            public static string Select_OutstationAllowanceApprovalFlowStatus = "Select_OutstationAllowanceApprovalFlowStatus";

            public static string SelectAllUserWiseEmployees = "SelectAllUserWiseEmployees";

            // Organization Hierarchy
            public static string SelectAllDesignationForOrganizationHierarchy = "SelectAllDesignationForOrganizationHierarchy";
            public static string SelectAllEmployeesForOrganizationHierarchy = "SelectAllEmployeesForOrganizationHierarchy";
            public static string SelectAllDesignationFlowForOrganizationHieararchy = "SelectAllDesignationFlowForOrganizationHieararchy";

            // Work Flow
            public static string SelectAllWorkFlow = "SelectAllWorkFlow";
            public static string SelectThisProcessByWorkFlowId = "SelectThisProcessByWorkFlowId";

            //Process
            public static string SelectAllProcess = "SelectAllProcess";

            //Letter Category
            public static string SelectLetterCategory = "SelectLetterCategory";
            
            // Get Table Structure
            public static string SelectAllLetterGenerationMap = "SelectAllLetterGenerationMap";

            public static string SelectAllLetterGenerateParser = "SelectAllLetterGenerateParser";

            //Appraisal Types
            public static string SelectAllAppraisalTypes = "SelectAllAppraisalTypes";
            public static string SelectAllAppraisalTypesByType = "SelectAllAppraisalTypesByType";

            //Appraisal Category
            public static string SelectAllAppraisalCategory = "SelectAllAppraisalCategory";

            //Appraisal Sub Category
            public static string SelectAllAppraisalSubCategory = "SelectAllAppraisalSubCategory";

            //Appraisal Element
            public static string SelectAllAppraisalElement = "SelectAllAppraisalElement";

            //Appraisal Element Type
            public static string SelectAllAppraisalElementType = "SelectAllAppraisalElementType";

            //Appraisal Element Wise Attributes For Pragraph Type
            public static string SelectAllAppraisalElementWiseAttributesForPragraphType = "SelectAllAppraisalElementWiseAttributesForPragraphType";

            //Appraisal Element Wise Attributes For Paragraph
            public static string SelectAllAppraisalElementWiseAttributesForParagraph = "SelectAllAppraisalElementWiseAttributesForParagraph";

            //List Of Attributes
            public static string SelectAllListOfAttributes = "SelectAllListOfAttributes";
            public static string SelectAllListOfAttributesHeader = "SelectAllListOfAttributesHeader";

            //Appraisal Element Wise Attributes For Questions
            public static string SelectAppraisalElementWiseAttributesForQuestions = "SelectAppraisalElementWiseAttributesForQuestions";
            public static string SelectAllAppraisalElementWiseAttributesForQuestionnier = "SelectAllAppraisalElementWiseAttributesForQuestionnier";

            //Appraisal For Question Sheet Generation
            public static string SelectAllAppraisalForQuestionSheetGeneration = "SelectAllAppraisalForQuestionSheetGeneration";

            public static string SelectAllWorkFlowApprovalLog = "SelectAllWorkFlowApprovalLog";

            public static string SelectApprovedOrRejectedWorkFlowApprovalLog = "SelectApprovedOrRejectedWorkFlowApprovalLog";

            //Appraisal Review Log
            public static string SelectAllAppraiasalReviewLog = "SelectAllAppraiasalReviewLog";

            //Employee Wise Activity Log Details
            public static string SelectAllEmployeeWiseActivityLogDetails = "SelectAllEmployeeWiseActivityLogDetails";

            //Traning Evaluation Form Header Template
            public static string SelectAllTraningEvaluationFormHeaderTemplate = "SelectAllTraningEvaluationFormHeaderTemplate";

            //Traning Evaluation Form Detail Template
            public static string SelectAllTraningEvaluationFormDetailTemplate = "SelectAllTraningEvaluationFormDetailTemplate";

            //Traning Schedule Evaluation Form Header
            public static string SelectAllTraningScheduleEvaluationFormHeader = "SelectAllTraningScheduleEvaluationFormHeader";

            //Traning Schedule Evaluation Form Detail
            public static string SelectAllTraningScheduleEvaluationFormDetail = "SelectAllTraningScheduleEvaluationFormDetail";

            //Tranig Evalutation Form Template
            public static string SelectThisTranigEvalutationFormTemplate = "SelectThisTranigEvalutationFormTemplate";

            //Appraisal Schedule Report
            public static string SelectAllAppraisalScheduleReport = "SelectAllAppraisalScheduleReport";

            // Leave Request For Report
            public static string SelectAllLeaveRequestReport = "SelectAllLeaveRequestReport";

            // Letter Print Log
            public static string SelectLetterPrintLog = "SelectLetterPrintLog";
            public static string rptSelectThisLetterPrintLog = "rpt_SelectThisLetterPrintLog";

            public static string SelectAllReviewsByTxnId = "SelectAllReviewsByTxnId";

            public static string SelectAllEmployeeWiseBenefitDetails = "SelectAllEmployeeWiseBenefitDetails";

            //Company Wise Reference Details
            public static string SelectAllCompanyWiseReferenceDetails = "SelectAllCompanyWiseReferenceDetails";

            //Company Wise Status
            public static string SelectAllCompanyWiseStatus = "SelectAllCompanyWiseStatus";

            //Password Policy
            public static string SelectAllPasswordPolicy = "SelectAllPasswordPolicy";

            //User Roles
            public static string SelectAllUserRole = "SelectAllUserRole";

           //Company Wise User Roles
            public static string SelectCompanyWiseUserRoles = "SelectCompanyWiseUserRoles";

            public static string SelectMenuLevelOne = "SelectMenuLevelOne";

            //System Access
            public static string SelectAllSystemAccess = "SelectAllSystemAccess";
            public static string SelectAllSystemAccessByUserRole = "SelectAllSystemAccessByUserRole";
            public static string SelectAllCompaniesAccessForUser = "SelectAllCompaniesAccessForUser";
            public static string SelectAllEmployeesByUserIdWithStatus = "SelectAllEmployeesByUserIdWithStatus";

            //Employee Benifit
            public static string SelectAllIssuedAndNotReturnedItemsByEmployeeWiseBenifitHeaderId = "SelectAllIssuedAndNotReturnedItemsByEmployeeWiseBenifitHeaderId";

            //Termination Feedback
            public static string SelectAllTerminationFeedbackQuestionaire = "SelectAllTerminationFeedbackQuestionaire";

            //Termination Feedback Answers
            public static string SelectAllTerminationFeedbackQuestionWiseAnswers = "SelectAllTerminationFeedbackQuestionWiseAnswers";

            //Termination Initiation
            public static string SelectThisTerminationInitiationByUser = "SelectThisTerminationInitiationByUser";

            //Talent Category
            public static string SelectAllTalentCategoryDetails = "SelectAllTalentCategoryDetails";

            //Talent Sub Category
            public static string SelectAllTalentSubCategory = "SelectAllTalentSubCategory";

            //Employee Wise Talent
            public static string SelectAllEmployeeWiseTalent = "SelectAllEmployeeWiseTalent";

            //Company Wise Status Wise Processes
            public static string SelectAllCompanyWiseStatusWiseProcesses = "SelectAllCompanyWiseStatusWiseProcesses";

            //Document Details
            public static string SelectAllDocumentDetails = "SelectAllDocumentDetails";

            //Employee Wise Documents Details
            public static string SelectAllEmployeeWiseDocumentsDetails = "SelectAllEmployeeWiseDocumentsDetails";
            
            //Pending Document Uploads
            public static string SelectPendingUploadDocuments = "SelectPendingUploadDocuments";

            //Employee Doc
            public static string SelectFolderNameByEmployee = "SelectFolderNameByEmployee";

            //Disciplinary Violation Types
            public static string SelectAllDisciplinaryViolationTypes = "SelectAllDisciplinaryViolationTypes";

            //Disciplinary Actions To Be Taken
            public static string SelectDisciplinaryActionsToBeTaken = "SelectDisciplinaryActionsToBeTaken";

            //Employee Wise Disciplinary Notice
            public static string SelectEmployeeWiseDisciplinaryNotice = "SelectEmployeeWiseDisciplinaryNotice";

            //Non Closed Employee Wise Disciplinary Notice
            public static string SelectNonClosedEmployeeWiseDisciplinaryNotice = "SelectNonClosedEmployeeWiseDisciplinaryNotice";

            //Employee Disciplinary Notice Wise Violations
            public static string SelectEmployeeDisciplinaryNoticeWiseViolations = "SelectEmployeeDisciplinaryNoticeWiseViolations";

            //Employee Disciplinary Notice Wise Withness
            public static string SelectEmployeeDisciplinaryNoticeWiseWithness = "SelectEmployeeDisciplinaryNoticeWiseWithness";

            //Employees By Disciplinary Notice Wise Withness
            public static string SelectAllEmployeesByDisciplinaryNoticeWiseWithness = "SelectAllEmployeesByDisciplinaryNoticeWiseWithness";
            
            //Employee Discliplinary Actions Hearings
            public static string SelectEmployeeDiscliplinaryActions_Hearings = "SelectEmployeeDiscliplinaryActions_Hearings";


        }
        #endregion

        #region Insert SP's
        internal static class InsertSPs
        {
            public static string UpdateTrainingScheduleHeaderCompletion = "UpdateTrainingScheduleHeaderCompletion";

            public static string UpdateTrainingScheduleDetailCompletion = "UpdateTrainingScheduleDetailCompletion";

            public static string InsertDesignationWiseTrainingDetails = "InsertDesignationWiseTrainingDetails";

            public static string UpdateWorkFlowApprovalLog = "UpdateWorkFlowApprovalLog";

            public static string InsertTrainingScheduleDetails = "InsertTrainingScheduleDetails";

            public static string InsertTrainingScheduleHeader = "InsertTrainingScheduleHeader";

            public static string InsertTrainingRequestDetails = "InsertTrainingRequestDetails";

            public static string InsertTrainingCategoryDetails = "InsertTrainingCategoryDetails";

            public static string InsertTerminationDueList = "InsertTerminationDueList";

            public static string UpdateTerminationDueListIsDone = "UpdateTerminationDueListIsDone";

            public static string InsertEmployeeWiseCollectableItems = "InsertEmployeeWiseCollectableItems";

            public static string InsertDesignationWiseCollectables = "InsertDesignationWiseCollectables";

            public static string InsertEmployeeCollectableItemsCheckList = "InsertEmployeeCollectableItemsCheckList";

            public static string InsertEmployeeTerminationInitiate = "InsertEmployeeTerminationInitiate";

            public static string InsertTerminationReason = "InsertTerminationReason";

            public static string InsertCompanyWiseTerminationEntitlementForTerminationCategory = "InsertCompanyWiseTerminationEntitlementForTerminationCategory";

            public static string InsertTerminationCategories = "InsertTerminationCategories";

            public static string InsertAppraisalScheduleDataDetails = "InsertAppraisalScheduleDataDetails";

            public static string InsertAppraisalScheduleDataHeader = "InsertAppraisalScheduleDataHeader";

            public static string InsertApprasalSheduleDetails = "InsertApprasalSheduleDetails";

            public static string InsertListOfAttributesValueHeader = "InsertListOfAttributesValueHeader";

            public static string InsertAppraisalElimentWiseQuestionHeaderDetails = "InsertAppraisalElimentWiseQuestionHeaderDetails";

            public static string InsertAppraisalElementWiseQuestionDetails = "InsertAppraisalElementWiseQuestionDetails";

            public static string InsertLetterTemplateDetails = "InsertLetterTemplateDetails";

            public static string InsertDesignationWiseWorkFlowDetails = "InsertDesignationWiseWorkFlowDetails";

            public static string InsertOrUpdateLeaveRequestApproval = "InsertOrUpdateLeaveRequestApproval";

            public static string InsertLeaveApprovalFlowDetails = "InsertLeaveApprovalFlowDetails";
            
            public static string InsertPromotionRequestApprovalLogDetails = "InsertPromotionRequestApprovalLogDetails";

            public static string UpdatePromotionRequestLogDetails = "UpdatePromotionRequestLogDetails";

            public static string InsertPromotionRequestLogDetails = "InsertPromotionRequestLogDetails";
            
            public static string InsertEmployeeWiseCommitmentLogDetails = "InsertEmployeeWiseCommitmentLogDetails";

            public static string InsertEmployeeWiseActivityLogDetails = "InsertEmployeeWiseActivityLogDetails";

            public static string InsertEmployeeWiseBenifitRenewableLogDetails = "InsertEmployeeWiseBenifitRenewableLogDetails";

            public static string InsertEmployeeWiseBenifitLogDetails = "InsertEmployeeWiseBenifitLogDetails";

            public static string InsertReturnedBenifits = "InsertReturnedBenifits";

            public static string InsertEmployeeWiseBenifitHeaderDetails = "InsertEmployeeWiseBenifitHeaderDetails";

            public static string InsertEmployeeBenifitApproveLevelDetails = "InsertEmployeeBenifitApproveLevelDetails";

            public static string InsertDesignationWiseBenifitDetails = "InsertDesignationWiseBenifitDetails";

            public static string InsertEmployeeBenifiedDetails = "InsertEmployeeBenifiedDetails";

            public static string InsertCompanyWiseDesignationDetails = "InsertCompanyWiseDesignationDetails";

            public static string InsertEmployeeWiseClasificationDetails = "InsertEmployeeWiseClasificationDetails";

            public static string InsertEmployeeWiseAddressDetails = "InsertEmployeeWiseAddressDetails";
            
            public static string InsertCountryDetails = "InsertCountryDetails";

            public static string InsertLeaveApprovedLevels = "InsertLeaveApprovedLevels";

            public static string InsertCompanyWiseLeaveTypeDetails = "InsertCompanyWiseLeaveTypeDetails";

            public static string InsertLeaveTypeDetails = "InsertLeaveTypeDetails";

            public static string InsertEmployeeWiseInterestDetails = "InsertEmployeeWiseInterestDetails";

            public static string InsertEmployeeWiseRelationshipDetails = "InsertEmployeeWiseRelationshipDetails";

            public static string InsertClasificationDetails = "InsertClasificationDetails";

            public static string InsertRelationshipDetails = "InsertRelationshipDetails";

            public static string InsertBloodGroupDetails = "InsertBloodGroupDetails";

            public static string InsertDepartmentDetails = "InsertDepartmentDetails";

            public static string InsertBranchDetails = "InsertBranchDetails";

            public static string InsertCityDetails = "InsertCityDetails";

            public static string InsertDesignationSlotDetails = "InsertDesignationSlotDetails";

            //Genaral
            public static string GEN_insertCurrencyDetails = "GEN_InsertCurrencyDetails";
            public static string GEN_insertHotelDetails = "GEN_InsertHotelDetails";
            public static string GEN_insertRegionDetails = "GEN_insertRegionDetails";
            public static string FO_InsertGEN_CountryDetails = "FO_InsertGEN_CountryDetails";

            //FO_InsertFO_RoomAdditionalDetails
            public static string FO_InsertFO_RoomAdditionalDetails = "FO_InsertFO_RoomAdditionalDetails";

            //FO
            public static string FO_insertSeasonCategoryDetails = "FO_InsertFO_SeasonCategories";
            public static string FO_insertRoomTypeDetails = "FO_InsertFO_RoomTypeDetails";

            public static string FO_insertRoomArea = "FO_InsertRoomAreaDetails";
            // public static string FO_insertRoomResourcesDetails = "FO_InsertRoomResourcesDetails";

            public static string insertFO_Nationality = "FO_InsertFO_Nationality";
            public static string FO_insertFO_AirLineDetails = "FO_insertFO_AirLineDetails";
            public static string FO_insertFO_AirPortDetails = "FO_insertFO_AirPortDetails";

            //FO_InsertFO_CancelReservations
            public static string FO_InsertFO_CancelReservations = "FO_InsertFO_CancelReservations";

            //FO_InsertFO_ReservationWiseReminders
            public static string FO_InsertFO_ReservationWiseReminders = "FO_InsertFO_ReservationWiseReminders";

            //FO_InsertFO_WaitListedReservations
            public static string FO_InsertFO_WaitListedReservations = "FO_InsertFO_WaitListedReservations";

            //FO_InsertFO_RoomAdditionalHeader
            public static string FO_InsertFO_RoomAdditionalHeader = "FO_InsertFO_RoomAdditionalHeader";

            //FO_InsertFO_Transfers
            public static string FO_InsertFO_Transfers = "FO_InsertFO_Transfers";

            //FO_InsertFO_GuestMessages
            public static string FO_InsertFO_GuestMessages = "FO_InsertFO_GuestMessages";

            //FO_InsertFO_ReservationWiseInventoryItems
            public static string FO_InsertFO_ReservationWiseInventoryItems = "FO_InsertFO_ReservationWiseInventoryItems";

            //FO_InsertFO_ReservationComments
            public static string FO_InsertFO_ReservationComments = "FO_InsertFO_ReservationComments";

            // Telephone Monitoring
            public static string FO_insertFO_TelephoneNumberDetails = "FO_Insert_FO_TelephoneNumberDetails";
            public static string FO_insertFO_TelephoneLines = "FO_insertFO_TelephoneLines";
            public static string FO_InsertFO_TelephoneRateTypes = "FO_InsertFO_TelephoneRateTypes";
            public static string FO_InsertFO_TeleponeExtentionGroups = "FO_InsertFO_TeleponeExtentionGroups";

            //FO_InsertFO_ReservationWiseAlerts
            public static string FO_InsertFO_ReservationWiseAlerts = "FO_InsertFO_ReservationWiseAlerts";


            public static string FO_InsertFO_VisitPurposeDetails = "FO_InsertFO_VisitPurposeDetails";
            public static string FO_InsertFO_Terminals = "FO_InsertFO_Terminals";
            public static string insertFO_TourOperatorDetails = "FO_InsertFO_TourOperatorDetails";

            public static string insertGEN_CountryDetails = "FO_InsertGEN_CountryDetails";

            //Other
            public static string insertUserDetails = "InsertUserDetails";
            public static string insertUserAccess = "InsertUserAccess";

            public static string insertWebAccess = "insertWebAccess";
            public static string FO_insertFO_ArrivalLocation = "FO_insertFO_ArrivalLocation";
            public static string fO_InsertFO_ArrivalModeDetails = "FO_InsertFO_ArrivalModeDetails";


            public static string insertFO_ConfirmationMethords = "FO_InsertFO_ConfirmationMethords";
            public static string insertFO_GuestComplainTypes = "FO_insertFO_GuestComplainTypes";
            public static string insertFO_GuestStatusDetails = "FO_insertFO_GuestStatusDetails";
            public static string insertFO_NameTitleDetails = "FO_insertFO_NameTitleDetails";

            public static string insertFO_OutOfOrderReasones = "FO_insertFO_OutOfOrderReasones";
            public static string insertFO_ReservationStatus = "FO_insertFO_ReservationStatus";
            public static string insertFO_RoomAreaDetails = "FO_insertFO_RoomAreaDetails";

            //TracesNeeds
            public static string FO_InsertFO_TracesDetails = "FO_InsertFO_TracesDetails";

            //Segment Details
            public static string FO_InsertFO_SegmentDetails = "FO_InsertFO_SegmentDetails";

            //Rate Code
            public static string FO_InsertFO_RateCode = "FO_InsertFO_RateCode";

            //Package Details
            public static string FO_InsertFO_PackageDetails = "FO_InsertFO_PackageDetails";

            public static string FO_Insert_FO_CustomerWiseAttributeValues = "FO_Insert_FO_CustomerWiseAttributeValues";
            public static string FO_Delete_FO_CustomerWiseAttributeValues = "FO_Delete_FO_CustomerWiseAttributeValues";

            //FO_InsertFO_RoomSharesDetails
            public static string FO_InsertFO_RoomSharesDetails = "FO_InsertFO_RoomSharesDetails";

            //FO_MarketCategory
            public static string FO_InsertFO_MarketCategory = "FO_InsertFO_MarketCategory";

            //FO_SourceCategory
            public static string FO_InsertFO_SourceCategory = "FO_InsertFO_SourceCategory";

            //FO_Market
            public static string FO_InsertFO_Market = "FO_InsertFO_Market";

            //FO_InsertFO_TransferTypes
            public static string FO_InsertFO_TransferTypes = "FO_InsertFO_TransferTypes";

            //FO_Source
            public static string FO_InsertFO_Source = "FO_InsertFO_Source";

            //FO_ReservationTypes
            public static string FO_InsertFO_ReservationTypes = "FO_InsertFO_ReservationTypes";

            //FO_VIPDetails
            public static string FO_InsertFO_VIPDetails = "FO_InsertFO_VIPDetails";

            //FO_RateCodeHeader
            public static string FO_InsertFO_RateCodeHeader = "FO_InsertFO_RateCodeHeader";


            #region Insert's Meal Plan Details
            //MealPlan Details
            public static string FO_InsertFO_MealPlanDetails = "FO_InsertFO_MealPlanDetails";
            #endregion

            #region Insert's Room Category Details
            //Room Category Details
            public static string FO_InsertFO_RoomCategories = "FO_InsertFO_RoomCategories";
            #endregion

            #region Insert's Room Resource Details
            //Room Category Details
            public static string FO_InsertFO_RoomResourceDetails = "FO_InsertFO_RoomResourceDetails";
            #endregion

            #region Insert's Room Details
            //Room Details
            public static string FO_InsertFO_RoomDetails = "FO_InsertFO_RoomDetails";
            public static string FO_UpdateFO_RoomDetails_HouseKeepingStatus = "FO_UpdateFO_RoomDetails_HouseKeepingStatus";
            #endregion

            //Hotel Wise Segment Details
            public static string FO_InsertFO_HotelWiseSegmentDetails = "FO_InsertFO_HotelWiseSegmentDetails";

            //Hotel Wise Package Details
            public static string FO_InsertFO_HotelWisePackageDetails = "FO_InsertFO_HotelWisePackageDetails";

            //Hotel Wise Rate Code Details
            public static string FO_InsertFO_HotelWiseRateCodeDetails = "FO_InsertFO_HotelWiseRateCodeDetails";

            //Hotel Wise Room Rate Types Details
            public static string FO_InsertFO_HotelWiseRoomRateTypesDetails = "FO_InsertFO_HotelWiseRoomRateTypesDetails";

            //Bed Type Details
            public static string FO_InsertFO_BedTypeDetails = "FO_InsertFO_BedTypeDetails";

            //Hotel Wise Market Details
            public static string FO_InsertFO_HotelWiseMarketDetails = "FO_InsertFO_HotelWiseMarketDetails";

            //RoomRateTypeDetails
            public static string insertFO_FO_RoomRateTypeDetails = "FO_InsertFO_RoomRateTypeDetails";

            //FO_InsertFO_RoomReservationHeader
            public static string FO_InsertFO_RoomReservationHeader = "FO_InsertFO_RoomReservationHeader";

            //FO_InsertFO_RoomReservationDetail
            public static string FO_InsertFO_RoomReservationDetail = "FO_InsertFO_RoomReservationDetail";

            //FO_InsertFO_RoomReservationDates
            public static string FO_InsertFO_RoomReservationDates = "FO_InsertFO_RoomReservationDates";
            public static string FO_UpdateFO_RoomReservationDates_RoomNumber = "FO_UpdateFO_RoomReservationDates_RoomNumber";

            // Hotel wise Season Category
            public static string insertFO_FO_HotelwiseSeasonCategory = "insertFO_FO_HotelwiseSeasonCategory";

            //Market Details
            public static string FO_InsertFO_MarketDetails = "FO_InsertFO_MarketDetails";

            //Void Reasons
            public static string FO_InsertFO_VoidReasons = "FO_InsertFO_VoidReasons";

            #region Insert HotelWise Room Category
            // Hotel wise Room Category
            public static string FO_InsertFO_HotelWiseRoomCategoryDetails = "FO_InsertFO_HotelWiseRoomCategoryDetails";
            #endregion

            #region Insert HotelWise RoomCategoryWise Resoures
            // Hotelwise RoomCategorWise Resources
            public static string FO_InsertFO_HotelWiseRoomCategoryResources = "FO_InsertFO_HotelWiseRoomCategoryResources";
            public static string insertFO_CustomerMaster = "FO_insertFO_CustomerMaster";
            public static string insertFO_CancellationPolicy;
            #endregion

            public static string FO_InsertFO_RoomRateHeader = "FO_InsertFO_RoomRateHeader";
            public static string FO_InsertFO_RoomRateDetails = "FO_InsertFO_RoomRateDetails";

            public static string FO_InsertFO_RemindMethods = "FO_InsertFO_RemindMethods";

            //[FO_InsertFO_RateCodeRates]
            public static string FO_InsertFO_RateCodeRates = "FO_InsertFO_RateCodeRates";

            //FO_InsertFO_RateCodeRatesChild
            public static string FO_InsertFO_RateCodeRatesChild = "FO_InsertFO_RateCodeRatesChild";


            //MiscBillCategory
            public static string FO_InsertFO_MiscBillCategory = "FO_InsertFO_MiscBillCategory";
            public static string insertFO_MealReservationMealType = "FO_insertFO_MealReservationMealType";

            //MiscBillTypes
            public static string FO_InsertFO_MiscBillTypes = "FO_InsertFO_MiscBillTypes";

            //Misc Module Category
            public static string FO_InsertFO_MiscModuleCategory = "FO_InsertFO_MiscModuleCategory";

            //Staff Wise 
            public static string FO_insertFO_StaffWiseInterfaceIDDetails = "FO_insertFO_StaffWiseInterfaceIDDetails";

            //Misc Module Item Categories
            public static string FO_InsertFO_MiscModuleItemCategories = "FO_InsertFO_MiscModuleItemCategories";

            //MiscModuleCategoriesItem
            public static string FO_InsertFO_MiscModuleCategoriesItem = "FO_InsertFO_MiscModuleCategoriesItem";

            //FO_RateCategory
            public static string FO_InsertFO_RateCategory = "FO_InsertFO_RateCategory";

            //FO_LanguageDetails
            public static string FO_InsertFO_LanguageDetails = "FO_InsertFO_LanguageDetails";

            //FO_CommunicationTypes
            public static string FO_InsertFO_CommunicationTypes = "FO_InsertFO_CommunicationTypes";

            //FO_InterestDetails
            public static string FO_InsertFO_InterestDetails = "FO_InsertFO_InterestDetails";

            //FO_GuestProfile
            public static string FO_InsertFO_GuestProfile = "FO_InsertFO_GuestProfile";

            //FO_Designations
            public static string FO_InsertFO_Designations = "FO_InsertFO_Designations";

            //FO_TransactionCodes
            public static string FO_InsertFO_TransactionCodes = "FO_InsertFO_TransactionCodes";

            //FO_RateCodeDetail
            public static string FO_InsertFO_RateCodeDetail = "FO_InsertFO_RateCodeDetail";

            //FO_CommentArea
            public static string FO_InsertFO_CommentArea = "FO_InsertFO_CommentArea";

            //FO_InsertFO_ReservationCancellationReasons
            public static string FO_InsertFO_ReservationCancellationReasons = "FO_InsertFO_ReservationCancellationReasons";

            //FO_InsertFO_QueuedReservations
            public static string FO_InsertFO_QueuedReservations = "FO_InsertFO_QueuedReservations";

            //FO_CommissionTypes
            public static string FO_InsertFO_CommissionTypes = "FO_InsertFO_CommissionTypes";

            //FO_InsertFO_WaitListedReasons
            public static string FO_InsertFO_WaitListedReasons = "FO_InsertFO_WaitListedReasons";

            //FO_InsertFO_PriorityDetails
            public static string FO_InsertFO_PriorityDetails = "FO_InsertFO_PriorityDetails";

            //GEN_InsertGEN_DepartmentDetails
            public static string GEN_InsertGEN_DepartmentDetails = "GEN_InsertGEN_DepartmentDetails";

            //FO_InsertFO_RateCodeWiseAttributes
            public static string FO_InsertFO_RateCodeWiseAttributes = "FO_InsertFO_RateCodeWiseAttributes";

            //FO_RateCodeWiseMealPlans
            public static string FO_InsertFO_RateCodeWiseMealPlans = "FO_InsertFO_RateCodeWiseMealPlans";

            //FO_RateCodeWisePackage
            public static string FO_InsertFO_RateCodeWisePackage = "FO_InsertFO_RateCodeWisePackage";

            //FO_InsertFO_RoomInventoryItems
            public static string FO_InsertFO_RoomInventoryItems = "FO_InsertFO_RoomInventoryItems";

            //FO_InsertFO_GuestRequest
            public static string FO_InsertFO_GuestRequest = "FO_InsertFO_GuestRequest";

            //Designation Details -> Insert
            public static string InsertDesignationDetails = "InsertDesignationDetails";

            //Level Details -> Insert
            public static string InsertLevelDetails = "InsertLevelDetails";

            //Grade Detals
            public static string InsertGradeDetails = "InsertGradeDetails";

            //Company Details
            public static string InsertCompanyDetails = "InsertCompanyDetails";

            //Salary Band Details
            public static string InsertSalaryBandDetails = "InsertSalaryBandDetails";

            //CompanywiseLevelDetails
            public static string InsertCompanyWiseLevelDetails = "InsertCompanyWiseLevelDetails";

            //Race Details
            public static string InsertRaceDetails = "InsertRaceDetails";

            //InsertNationalityDetails 
            public static string InsertNationalityDetails = "InsertNationalityDetails";

            //Religion Details
            public static string InsertReligionDetails = "InsertReligionDetails";

            //Province Details
            public static string InsertProvinceDetails = "InsertProvinceDetails";

            //District Details
            public static string InsertDistrictDetails = "InsertDistrictDetails";

            //Cost Center Details
            public static string InsertCostCenterDetails = "InsertCostCenterDetails";

            //Employee Status Details
            public static string InsertEmployeeStatusDetails = "InsertEmployeeStatusDetails";

            //Education Level Details
            public static string InsertEducationLevelDetails = "InsertEducationLevelDetails";

            //Classification Header Details
            public static string InsertClassificationHeaderDetails = "InsertClassificationHeaderDetails";

            //Employee Deatails
            public static string InsertEmployeeDetails = "InsertEmployeeDetails";

            //Employee Wise Helth Profile Deatails
            public static string InsertEmployeeWiseHelthProfile = "InsertEmployeeWiseHelthProfileDetails";

            //Employee  Wise Qualification Deatails
            public static string InsertEmployeeWiseQualificationDetails = "InsertEmployeeWiseQualificationsDetail";

            //Employee Wise Achievement Detail

            public static string InsertEmployeeWiseAchievementDetail = "InsertEmployeeWiseAchievementDetail";

            // Designation Wise Leave Detail

            public static string InsertDesignationWiseLeaveTypeDetails = "InsertDesignationWiseLeaveType";

            // Employee Wise Leave Detail

            public static string InsertEmployeeWiseLeaveTypesDetails = "InsertEmployeeWiseLeaveTypesDetails";

            // Employee Wise Leave Detail

            public static string InsertEmployeeWiseReferenceDetails = "InsertEmployeeWiseReferenceDetails";

            //Assets Inventory Details
            public static string InsertAssetsInventoryDetails = "InsertAssetsInventoryDetails";

            //Promotion Designation Approval Level Details
            public static string InsertPromotionDesignationApprovalLevelDetails = "InsertPromotionDesignationApprovalLevelDetails";

            //Employee Wise Benifit Details
            public static string InsertEmployeeWiseBenifitDetails = "InsertEmployeeWiseBenifitDetails";

            //Employee Wise Benifit Header Details Assign Process
            public static string InsertEmployeeWiseBenifitHeaderDetailsAssignProcess = "InsertEmployeeWiseBenifitHeaderDetailsAssignProcess";


            //INSERT (UPDATE) Employee Wise Benifit Log Assign Process
            public static string UpdateEmployeeWiseBenifitLogAssignProcess = "UpdateEmployeeWiseBenifitLogAssignProcess";

            //Employee Wise Benifit Details Assign Process
            public static string InsertEmployeeWiseBenifitDetailsAssignProcess = "InsertEmployeeWiseBenifitDetailsAssignProcess";

            //User Wise Company Access Details
            public static string InsertUserWiseCompanyAccessDetails = "InsertUserWiseCompanyAccessDetails";


            //Main Menu Assignment -> Gen_MainMenu
            public static string InsertGen_MainMenu = "InsertGen_MainMenu";

            // Sub Menu Level 1 Assignement
            public static string InsertGen_SubMenuLevel1 = "InsertGen_SubMenuLevel1";

            //Sub Menu Level 2 Assignment
            public static string InsertGen_SubMenuLevel2 = "InsertGen_SubMenuLevel2";

            //Sub Menu Level 3 Assignemnt
            public static string InsertGen_SubMenuLevel3 = "InsertGen_SubMenuLevel3";

            public static string InsertUploadImageData = "InsertUploadImageData";

            //Company Wise Leave Units
            public static string InsertCompanyWiseLeaveUnits = "InsertCompanyWiseLeaveUnits";

            //Leave Request
            public static string InsertLeaveRequest = "InsertLeaveRequest";

            //Outstation Allowance
            public static string InsertOutstationAllowance = "InsertOutstationAllowance";

            //Work Flow
            public static string InsertWorkFlowDetails = "InsertWorkFlowDetails";
            
            //Letter Category
            public static string InsertLetterCategory = "InsertLetterCategory";
            
            //Appraisal Types
            public static string InsertAppraisalTypes = "InsertAppraisalTypes";

            //Appraisal Category
            public static string InsertAppraisalCategory = "InsertAppraisalCategory";

            //Appraisal Sub Category
            public static string InsertAppraisalSubCategory = "InsertAppraisalSubCategory";

            //Appraisal Element
            public static string InsertAppraisalElement = "InsertAppraisalElement";

            //Appraisal Element Wise Attributes For Praragarph 
            public static string InsertAppraisalElementWiseAttributesForPraragarph = "InsertAppraisalElementWiseAttributesForPraragarph";

            //List Of Attributes
            public static string InsertListOfAttributes = "InsertListOfAttributes";

            //Appraisal Element Wise Attributes For Questions
            public static string InsertAppraisalElementWiseAttributesForQuestions = "InsertAppraisalElementWiseAttributesForQuestions";

            //Work Flow Approval Log
            public static string InsertWorkFlowApprovalLog = "InsertWorkFlowApprovalLog";
            public static string InsertWorkFlowApprovalLogDetails = "InsertWorkFlowApprovalLogDetails";

            //Appraisal Review Log
            public static string InsertAppraiasalReviewLog = "InsertAppraiasalReviewLog"; 
            
            // Traning Evaluation Form Header Template
            public static string InsertTraningEvaluationFormHeaderTemplate = "InsertTraningEvaluationFormHeaderTemplate";

            //Traning Evaluation Form Detail Template
            public static string InsertTraningEvaluationFormDetailTemplate = "InsertTraningEvaluationFormDetailTemplate";

            //Traning Schedule Evaluation Form Header
            public static string InsertTraningScheduleEvaluationFormHeader = "InsertTraningScheduleEvaluationFormHeader";

            //Traning Schedule Evaluation Form Detail
            public static string InsertTraningScheduleEvaluationFormDetail = "InsertTraningScheduleEvaluationFormDetail";
            
            //Letter Print Log
            public static string InsertLetterPrintLog = "InsertLetterPrintLog";
            public static string UpdateLetterPrintLog = "UpdateLetterPrintLog";

            //Company Wise Reference Details
            public static string InsertCompanyWiseReferenceDetails = "InsertCompanyWiseReferenceDetails";

            //Company Wise Status
            public static string InsertCompanyWiseStatus = "InsertCompanyWiseStatus";

            //Password Policy
            public static string InsertPasswordPolicy = "InsertPasswordPolicy";

            //User Roles
            public static string InsertUserRole = "InsertUserRole";

            //Company Wise User Roles
            public static string InsertCompanyWiseUserRoles = "InsertCompanyWiseUserRoles";

            //System Access
            public static string InsertSystemAccess = "InsertSystemAccess";

            //Termination Feedback
            public static string InsertTerminationFeedbackQuestionaire = "InsertTerminationFeedbackQuestionaire";

            //Termination Feedback Answers
            public static string InsertTerminationFeedbackQuestionWiseAnswers = "InsertTerminationFeedbackQuestionWiseAnswers";

            //Talent Category Details
            public static string InsertTalentCategoryDetails = "InsertTalentCategoryDetails";


            //Talent Sub Category Details
            public static string InsertTalentSubCategory = "InsertTalentSubCategory";

            //Employee Wise Talent Details
            public static string InsertEmployeeWiseTalent = "InsertEmployeeWiseTalent";

            //Company Wise Status Wise Processes
            public static string InsertCompanyWiseStatusWiseProcesses = "InsertCompanyWiseStatusWiseProcesses";

            public static string InsertDocumentDetails = "InsertDocumentDetails";
            
            //Employee Wise Documents Details
            public static string InsertEmployeeWiseDocumentsDetails = "InsertEmployeeWiseDocumentsDetails";

            //Employee Folder Name
            public static string UpdateEmployeeFolderName = "UpdateEmployeeFolderName";

            //Disciplinary Violation Types
            public static string InsertDisciplinaryViolationTypes = "InsertDisciplinaryViolationTypes";

            //Disciplinary Actions To Be Taken
            public static string InsertDisciplinaryActionsToBeTaken = "InsertDisciplinaryActionsToBeTaken";

            //Employee Wise Disciplinary Notice
            public static string InsertEmployeeWiseDisciplinaryNotice = "InsertEmployeeWiseDisciplinaryNotice";

            //Employee Disciplinary Notice Wise Violations
            public static string InsertEmployeeDisciplinaryNoticeWiseViolations = "InsertEmployeeDisciplinaryNoticeWiseViolations";

            //Employee Disciplinary Notice Wise Withness
            public static string InsertEmployeeDisciplinaryNoticeWiseWithness = "InsertEmployeeDisciplinaryNoticeWiseWithness";

            //Employee Discliplinary Actions Hearings
            public static string InsertEmployeeDiscliplinaryActions_Hearings = "InsertEmployeeDiscliplinaryActions_Hearings";

            //Employee Wise Disciplinary Actions Supervision
            public static string InsertEmployeeWiseDisciplinaryActions_Supervision = "InsertEmployeeWiseDisciplinaryActions_Supervision";

            //Employee Desciplinary Action - Corrective Actions To Be Taken
            public static string InsertEmployeeDesciplinaryAction_CorrectiveActionsToBeTaken = "InsertEmployeeDesciplinaryAction_CorrectiveActionsToBeTaken";

        }

        #endregion

        #region Delete's SP's
        internal static class DeleteSPs
        {
            public static string DeleteDesignationWiseTrainingDetails = "DeleteDesignationWiseTrainingDetails";

            public static string DeleteTrainingCategoryDetails = "DeleteTrainingCategoryDetails";

            public static string DeleteTrainingRequestDetails = "DeleteTrainingRequestDetails";

            public static string DeleteTerminationDueList = "DeleteTerminationDueList";

            public static string DeleteEmployeeWiseCollectableItems = "DeleteEmployeeWiseCollectableItems";

            public static string DeleteDesignationWiseCollectables = "DeleteDesignationWiseCollectables";

            public static string DeleteEmployeeCollectableItemsCheckList = "DeleteEmployeeCollectableItemsCheckList";

            public static string DeleteEmployeeTerminationInitiate = "DeleteEmployeeTerminationInitiate";

            public static string DeleteTerminationReason = "DeleteTerminationReason";

            public static string DeleteCompanyWiseTerminationEntitlementForTerminationCategory = "DeleteCompanyWiseTerminationEntitlementForTerminationCategory";

            public static string DeleteTerminationCategories = "DeleteTerminationCategories";

            public static string DeleteAppraisalScheduleDataDetails = "DeleteAppraisalScheduleDataDetails";

            public static string DeleteAppraisalScheduleDataHeader = "DeleteAppraisalScheduleDataHeader";

            public static string DeleteApprasalSchedule = "DeleteApprasalSchedule";

            public static string DeleteListOfAttributesHeader = "DeleteListOfAttributesHeader";

            public static string DeleteAppraisalElimentWiseQuestionHeaderDetails = "DeleteAppraisalElimentWiseQuestionHeaderDetails";

            public static string DeleteAppraisalElementWiseQuestionDetails = "DeleteAppraisalElementWiseQuestionDetails";

            public static string DeleteListOfAttributes = "DeleteListOfAttributes";

            public static string DeleteThisLetterTemplateDetails = "DeleteThisLetterTemplateDetails";

            public static string DeletetDesignationWiseWorkFlowDetails = "DeletetDesignationWiseWorkFlowDetails";

            public static string DeleteThisLeaveApprovalFlow = "DeleteThisLeaveApprovalFlow";

            public static string DeleteThisEmployeeWiseCommitmentLogDetails = "DeleteThisEmployeeWiseCommitmentLogDetails";

            public static string DeleteEmployeeWiseBenifitRenewableLogDetails = "DeleteEmployeeWiseBenifitRenewableLogDetails";

            public static string DeleteThisEmployeeWiseBenifitLogDetails = "DeleteThisEmployeeWiseBenifitLogDetails";

            public static string DeleteThisEmployeeWiseBenifitHeaderDetails = "DeleteThisEmployeeWiseBenifitHeaderDetails";

            public static string DeleteThisEmployeeBenifitApproveLevelsDetails = "DeleteThisEmployeeBenifitApproveLevelsDetails";

            public static string DeleteThisDesignationWiseBenifitDetails = "DeleteThisDesignationWiseBenifitDetails";

            public static string DeleteThisEmployeeBenifitDetails = "DeleteThisEmployeeBenifitDetails";

            public static string DeleteCompanyWiseDesignationDetails = "DeleteCompanyWiseDesignationDetails";

            public static string DeleteThisEmployeeWiseAddressDetails = "DeleteThisEmployeeWiseAddressDetails";

            public static string DeleteThisCountryDetails = "DeleteThisCountryDetails";

            public static string DeleteThisLeaveApprovedLevels = "DeleteThisLeaveApprovedLevels";
            
            public static string DeleteThisCompanyWiseLeaveTypeDetails = "DeleteThisCompanyWiseLeaveTypeDetails";

            public static string DeleteThisLeaveTypeDetails = "DeleteThisLeaveTypeDetails";

            public static string DeleteThisEmployeeWiseInterestDetails = "DeleteThisEmployeeWiseInterestDetails";

            public static string DeleteThisEmployeeWiseRelationshipDetails = "DeleteThisEmployeeWiseRelationshipDetails";

            public static string DeleteThisClasificationDetails = "DeleteThisClasificationDetails";

            public static string DeleteThisRelationshipDetails = "DeleteThisRelationshipDetails";

            public static string DeleteThisBloodGroupDetails = "DeleteThisBloodGroupDetails";

            public static string DeleteThisDepartmentDetails = "DeleteThisDepartmentDetails";

            public static string DeleteThisBranchDetails = "DeleteThisBranchDetails";

            public static string DeleteThisCityDetails = "DeleteThisCityDetails";
            public static string DeleteThisDesignationSlotDetails = "DeleteThisDesignationSlotDetails";

            public static string DeleteThisNationalityDetails = "DeleteThisNationalityDetails";
            public static string FO_DeleteFO_RemindMethods = "FO_DeleteFO_RemindMethods";

            public static string FO_deleteSeasonCategoryDetails = "FO_DeleteFO_SeasonCategoryDetails";
            public static string FO_deleteRoomTypeDetails = "FO_DeleteFO_RoomTypeDetails";
            public static string GEN_deleteCurrencyDetails = "GEN_DeleteCurrencyDetails";

            public static string GEN_deleteRegionDetails = "GEN_DeleteRegionDetails";
            public static string GEN_deleteHotelDetails = "GEN_DeleteHotelDetails";

            //FO_DeleteFO_RoomAdditionalDetails
            public static string FO_DeleteFO_RoomAdditionalDetails = "FO_DeleteFO_RoomAdditionalDetails";

            // public static string FO_deleteRoomResourcesDetails = "FO_DeleteRoomResourcesDetails";
            public static string FO_deleteRoomAreaDetails = "FO_DeleteRoomAreaDetails";

            public static string deleteUserDetails = "delete_UserDetails";
            public static string deleteUserAccess = "DeleteUserAccess";
            public static string deleteWebAccess = "delete_WebAccess";
            public static string deleteFO_Nationality = "FO_deleteFO_Nationality";

            //FO_DeleteFO_CancelReservations
            public static string FO_DeleteFO_CancelReservations = "FO_DeleteFO_CancelReservations";

            // Telephone Monitoring 
            public static string deleteFO_TelephoneNumberDetails = "FO_delete_FO_TelephoneNumberDetails";
            public static string FO_deleteFO_TelephoneLines = "FO_deleteFO_TelephoneLines";
            public static string FO_DeleteFO_TelephoneRateTypes = "FO_DeleteFO_TelephoneRateTypes";
            public static string FO_DeleteFO_TeleponeExtentionGroups = "FO_DeleteFO_TeleponeExtentionGroups";

            //
            public static string FO_DeleteFO_VisitPurposeDetails = "FO_DeleteFO_VisitPurposeDetails";
            public static string FO_DeleteFO_Terminals = "FO_DeleteFO_Terminals";
            public static string deleteFO_TourOperatorDetails = "FO_DeleteFO_TourOperatorDetails";



            public static string FO_deleteFO_AirLineDetails = "FO_deleteFO_AirLineDetails";
            public static string FO_deleteFO_AirPortDetails = "FO_deleteFO_AirPortDetails";
            public static string FO_DeleteFO_ArrivalLocation = "FO_DeleteFO_ArrivalLocation";
            public static string deleteFO_ArrivalModeDetails = "FO_DeleteFO_ArrivalModeDetails";
            public static string deleteFO_ConfirmationMethords = "FO_DeleteFO_ConfirmationMethords";
            public static string deleteFO_GuestComplainTypes = "FO_deleteFO_GuestComplainTypes";
            public static string deleteFO_GuestStatusDetails = "FO_deleteFO_GuestStatusDetails";
            public static string deleteFO_NameTitleDetails = "FO_deleteFO_NameTitleDetails";
            public static string deleteFO_OutOfOrderReasones = "FO_deleteFO_OutOfOrderReasones";
            public static string deleteFO_ReservationStatus = "FO_deleteFO_ReservationStatus";
            public static string deleteFO_RoomAreaDetails = "FO_deleteFO_RoomAreaDetails";

            //TracesNeeds
            public static string FO_DeleteFO_TracesDetails = "FO_DeleteFO_TracesDetails";

            //Segment Details
            public static string FO_DeleteFO_SegmentDetails = "FO_DeleteFO_SegmentDetails";

            //Rate Code
            public static string FO_DeleteFO_RateCode = "FO_DeleteFO_RateCode";

            //FO_DeleteFO_RateCodeHeader
            public static string FO_DeleteFO_RateCodeHeader = "FO_DeleteFO_RateCodeHeader";

            //FO_DeleteFO_RateCodeRates
            public static string FO_DeleteFO_RateCodeRates = "FO_DeleteFO_RateCodeRates";
            public static string FO_DeleteFO_RateCodeRatesByIDs = "FO_DeleteFO_RateCodeRatesByIDs";

            //Package Details
            public static string FO_DeleteFO_PackageDetails = "FO_DeleteFO_PackageDetails";

            //FO_DeleteFO_WaitListedReasons
            public static string FO_DeleteFO_WaitListedReasons = "FO_DeleteFO_WaitListedReasons";

            //FO_DeleteFO_RoomSharesDetails
            public static string FO_DeleteFO_RoomSharesDetails = "FO_DeleteFO_RoomSharesDetails";

            #region Delete's Meal Plan Details
            //Meal Plan Details
            public static string FO_DeleteFO_MealPlanDetails = "FO_DeleteFO_MealPlanDetails";
            #endregion

            #region Delete's Room Category Details
            //Room Category Details
            public static string FO_DeleteFO_RoomCategories = "FO_DeleteFO_RoomCategories";
            #endregion

            #region Delete's Room Resource Details
            //Room Category Details
            public static string FO_DeleteFO_RoomResourceDetails = "FO_DeleteFO_RoomResourceDetails";
            #endregion

            #region Delete's Room  Details
            //Room  Details
            public static string FO_DeleteFO_RoomDetails = "FO_DeleteFO_RoomDetails";
            #endregion
            //Hotel Wise Segment Details
            public static string FO_DeleteFO_HotelWiseSegmentDetails = "FO_DeleteFO_HotelWiseSegmentDetails";

            //Hotel Wise Package Details
            public static string FO_DeleteFO_HotelWisePackageDetails = "FO_DeleteFO_HotelWisePackageDetails";

            //Hotel Wise Rate Code Details
            public static string FO_DeleteFO_HotelWiseRateCodeDetails = "FO_DeleteFO_HotelWiseRateCodeDetails";

            //Hotel Wise Room Rate Types Details
            public static string FO_DeleteFO_HotelWiseRoomRateTypesDetails = "FO_DeleteFO_HotelWiseRoomRateTypesDetails";

            //Bed Type Details
            public static string FO_DeleteFO_BedTypeDetails = "FO_DeleteFO_BedTypeDetails";

            //Hotel Wise Market Details
            public static string FO_DeleteFO_HotelWiseMarketDetails = "FO_DeleteFO_HotelWiseMarketDetails";

            //RoomRateTypeDetails
            public static string deleteFO_RoomRateTypeDetails = "FO_DeleteFO_RoomRateTypeDetails";

            //Hotel wise Season Category
            public static string deleteFO_HotelwiseSeasonCategory = "deleteFO_FO_HotelwiseSeasonCategory";

            //Market Details
            public static string FO_DeleteFO_MarketDetails = "FO_DeleteFO_MarketDetails";

            //Void Reasons
            public static string FO_DeleteFO_VoidReasons = "FO_DeleteFO_VoidReasons";

            //Misc Bill Category
            public static string FO_DeleteFO_MiscBillCategory = "FO_DeleteFO_MiscBillCategory";

            //MiscBillTypes
            public static string FO_DeleteFO_MiscBillTypes = "FO_DeleteFO_MiscBillTypes";

            //Misc Module Category
            public static string FO_DeleteFO_MiscModuleCategory = "FO_DeleteFO_MiscModuleCategory";

            //Misc Module Item Categories
            public static string FO_DeleteFO_MiscModuleItemCategories = "FO_DeleteFO_MiscModuleItemCategories";

            //FO_MiscModuleCategoriesItem
            public static string FO_DeleteFO_MiscModuleCategoriesItem = "FO_DeleteFO_MiscModuleCategoriesItem";

            //GEN Country Details
            public static string FO_DeleteGEN_CountryDetails = "FO_DeleteGEN_CountryDetails";

            //FO_RateCategory
            public static string FO_DeleteFO_RateCategory = "FO_DeleteFO_RateCategory";


            //FO_MarketCategory
            public static string FO_DeleteFO_MarketCategory = "FO_DeleteFO_MarketCategory";

            //FO_Market
            public static string FO_DeleteFO_Market = "FO_DeleteFO_Market";

            //FO_DeleteFO_TransferTypes
            public static string FO_DeleteFO_TransferTypes = "FO_DeleteFO_TransferTypes";

            //FO_Source
            public static string FO_DeleteFO_Source = "FO_DeleteFO_Source";

            //FO_SourceCategory
            public static string FO_DeleteFO_SourceCategory = "FO_DeleteFO_SourceCategory";

            //FO_ReservationTypes
            public static string FO_DeleteFO_ReservationTypes = "FO_DeleteFO_ReservationTypes";

            //FO_LanguageDetails
            public static string FO_DeleteFO_LanguageDetails = "FO_DeleteFO_LanguageDetails";

            //FO_VIPDetails
            public static string FO_DeleteFO_VIPDetails = "FO_DeleteFO_VIPDetails";

            //FO_CommunicationTypes
            public static string FO_DeleteFO_CommunicationTypes = "FO_DeleteFO_CommunicationTypes";

            //FO_InterestDetails
            public static string FO_DeleteFO_InterestDetails = "FO_DeleteFO_InterestDetails";

            //FO_Designations
            public static string FO_DeleteFO_Designations = "FO_DeleteFO_Designations";

            //FO_TransactionCodes
            public static string FO_DeleteFO_TransactionCodes = "FO_DeleteFO_TransactionCodes";

            //FO_RateCodeDetail
            public static string FO_DeleteFO_RateCodeDetail = "FO_DeleteFO_RateCodeDetail";
            public static string FO_DeleteFO_RateCodeDetailByRateCodeID = "FO_DeleteFO_RateCodeDetailByRateCodeID";
            public static string FO_DeleteFO_RateCodeDetailByRateCodeIDandDetailID = "FO_DeleteFO_RateCodeDetailByRateCodeIDandDetailID";

            //FO_CommentArea
            public static string FO_DeleteFO_CommentArea = "FO_DeleteFO_CommentArea";

            //FO_DeleteFO_ReservationCancellationReasons
            public static string FO_DeleteFO_ReservationCancellationReasons = "FO_DeleteFO_ReservationCancellationReasons";

            //FO_CommissionTypes
            public static string FO_DeleteFO_CommissionTypes = "FO_DeleteFO_CommissionTypes";

            //FO_DeleteFO_PriorityDetails
            public static string FO_DeleteFO_PriorityDetails = "FO_DeleteFO_PriorityDetails";

            //GEN_DeleteGEN_DepartmentDetails
            public static string GEN_DeleteGEN_DepartmentDetails = "GEN_DeleteGEN_DepartmentDetails";


            #region Delete HotelWise RoomCategory Details
            //Delete Hotel Wise Room Category Details
            public static string FO_DeleteFO_HotelWiseRoomCategoryDetails = "FO_DeleteFO_HotelWiseRoomCategoryDetails";
            #endregion


            #region Delete HotelWise RoomCategoryWise Resource Details
            //Delete HotelWise RoomCategoryWise Resource Details
            public static string FO_DeleteFO_HotelWiseRoomCategoryResources = "FO_DeleteFO_HotelWiseRoomCategoryResources";
            public static string deleteFO_CustomerMaster = "FO_deleteFO_CustomerMaster";
            public static string deleteFO_CancellationPolicy;
            public static string deleteFO_MealReservationMealType = "FO_deleteFO_MealReservationMealType";
            #endregion


            public static string FO_DeleteFO_StaffWiseInterfaceIDDetails = "FO_DeleteFO_StaffWiseInterfaceIDDetails";

            //FO_DeleteAllFO_RateCodeWiseAttributes
            public static string FO_DeleteAllFO_RateCodeWiseAttributes = "FO_DeleteAllFO_RateCodeWiseAttributes";
            public static string FO_DeleteAllFO_RateCodeWiseAttributesByID = "FO_DeleteAllFO_RateCodeWiseAttributesByID";

            //FO_DeleteAllFO_RateCodeWiseMealPlan
            public static string FO_DeleteAllFO_RateCodeWiseMealPlan = "FO_DeleteAllFO_RateCodeWiseMealPlan";
            public static string FO_DeleteAllFO_RateCodeWiseMealPlanByID = "FO_DeleteAllFO_RateCodeWiseMealPlanByID";

            //FO_DeleteAllFO_RateCodeWisePackage
            public static string FO_DeleteAllFO_RateCodeWisePackage = "FO_DeleteAllFO_RateCodeWisePackage";
            public static string FO_DeleteAllFO_RateCodeWisePackageByID = "FO_DeleteAllFO_RateCodeWisePackageByID";

            //FO_DeleteFO_RoomInventoryItems
            public static string FO_DeleteFO_RoomInventoryItems = "FO_DeleteFO_RoomInventoryItems";

            //FO_DeleteFO_GuestRequest
            public static string FO_DeleteFO_GuestRequest = "FO_DeleteFO_GuestRequest";

            //Designation Details -> Delete
            public static string DeleteDesignationDetails = "DeleteDesignationDetails";

            //Level Details -> Delete
            public static string DeleteLevelDetails = "DeleteLevelDetails";

            //DeleteGrade
            public static string DeleteThisGradeDetails = "DeleteThisGradeDetails";

            //CompanyGrade
            public static string DeleteThisCompanyDetails = "DeleteThisCompanyDetails";

            //Salary Band Details -> Delete
            public static string DeleteSalaryBandDetails = "DeleteSalaryBandDetails";

            //CompanyWiseLevelDetails
            public static string DeleteCompanyWiseLevelDetails = "DeleteCompanyWiseLevelDetails";

            //Race Details -> Delete
            public static string DeleteRaceDetails = "DeleteRaceDetails";

            //Religion Details -> Delete

            public static string DeleteReligionDetails = "DeleteReligionDetails";

            //Province Details -> Delete
            public static string DeleteProvinceDetails = "DeleteProvinceDetails";

            //District Details -> Delete
            public static string DeleteDistrictDetails = "DeleteDistrictDetails";

            //Cost Center Details -> Delete
            public static string DeleteCostCenterDetails = "DeleteCostCenterDetails";

            //Employee Status Details -> Delete
            public static string DeleteEmployeeStatusDetails = "DeleteEmployeeStatusDetails";

            //Education Level Details -> Delete
            public static string DeleteEducationLevelDetails = "DeleteEducationLevelDetails";

            //Classification Header Details -> Delete
            public static string DeleteClassificationHeaderDetails = "DeleteClassificationHeaderDetails";

            //Employee Details -> Delete
            public static string DeleteEmployeeDetails = "DeleteEmployeeDetails";

            //Employee Wise Helth Profile Details -> Delete
            public static string DeleteEmployeeWiseHelthProfileDetails = "DeleteEmployeeWiseHelthProfileDetails";

            //Employee Wise Qualification Details -> Delete
            public static string DeleteEmployeeWiseQualificationDetails = "DeleteEmployeeWiseQualificationDetails";

            //Employee Wise Achievement Details -> Delete
            public static string DeleteEmployeeWiseAchievementDetails = "DeleteEmployeeWiseAchievementDetail";

            //Designation Wise Leave Details -> Delete
            public static string DeleteDesignationWiseLeaveType = "DeleteDesignationWiseLeaveType";

            //Employee Wise Leave Details -> Delete
            public static string DeleteEmployeeWiseLeaveTypesDetails = "DeleteEmployeeWiseLeaveTypesDetails";

            //Employee Wise Reference Details -> Delete
            public static string DeleteEmployeeWiseReferenceDetails = "DeleteEmployeeWiseReferenceDetails";

            //Assets Inventory Details -> Delete
            public static string DeleteAssetsInventoryDetails = "DeleteAssetsInventoryDetails";

            //Promotion Designation Approval Level Details
            public static string DeletePromotionDesignationApprovalLevelDetails = "DeletePromotionDesignationApprovalLevelDetails";

            // Employee Wise Benifit Details
            public static string DeleteEmployeeWiseBenifitDetails = "DeleteEmployeeWiseBenifitDetails";

            // User Wise Company Access Details
            public static string DeleteUserWiseCompanyAccessDetails = "DeleteUserWiseCompanyAccessDetails";

            public static string DeleteCompanyWiseLeaveUnits = "DeleteCompanyWiseLeaveUnits";

            //Leave Request
            public static string DeleteLeaveRequest = "DeleteLeaveRequest";

            //Outstation Allowance
            public static string DeleteOutstationAllowance = "DeleteOutstationAllowance";

            //Work Flow
            public static string DeleteWorkFlow = "DeleteWorkFlow";

            //Letter Category
            public static string DeleteLetterCategory = "DeleteLetterCategory";

            // Appraisal Types
            public static string DeleteAppraisalTypes = "DeleteAppraisalTypes";

            // Appraisal Category
            public static string DeleteAppraisalCategory = "DeleteAppraisalCategory";

            //Appraisal Sub Category
            public static string DeleteAppraisalSubCategory = "DeleteAppraisalSubCategory";

            //Appraisal Element
            public static string DeleteAppraisalElement = "DeleteAppraisalElement";

            //Appraisal Element Wise Attributes For Paragraph
            public static string DeleteAppraisalElementWiseAttributesForParagraph = "DeleteAppraisalElementWiseAttributesForParagraph";

            //Appraisal Element Wise Attribute For Questions
            public static string DeleteAppraisalElementWiseAttributeForQuestions = "DeleteAppraisalElementWiseAttributeForQuestions";

            //Appraisal Flush Data..
            public static string DeleteAndFlushDataToAppraisalScheduleHistory = "DeleteAndFlushDataToAppraisalScheduleHistory";

            public static string DeleteExistingAppraisalsForInsertAppraisal = "DeleteExistingAppraisalsForInsertAppraisal";

            //Traning Evaluation Form Header Template
            public static string DeleteTraningEvaluationFormHeaderTemplate = "DeleteTraningEvaluationFormHeaderTemplate";


            //Traning Evaluation Form Detail Template
            public static string DeleteTraningEvaluationFormDetailTemplate = "DeleteTraningEvaluationFormDetailTemplate";

            //Company Wise Reference Details
            public static string DeleteCompanyWiseReferenceDetails = "DeleteCompanyWiseReferenceDetails";

            //Company Wise Status
            public static string DeleteCompanyWiseStatus = "DeleteCompanyWiseStatus";

            //Password Policy
            public static string DeletePasswordPolicy = "DeletePasswordPolicy";

            //User Roles
            public static string DeleteUserRole = "DeleteUserRole";

            //Company Wise User Roles
            public static string DeleteCompanyWiseUserRoles = "DeleteCompanyWiseUserRoles";

            //System Access
            public static string ClearAccessForMenus = "ClearAccessForMenus";

            //Termination Feedback
            public static string DeleteTerminationFeedbackQuestionaire = "DeleteTerminationFeedbackQuestionaire";

            //Termination Feedback Answers
            public static string DeleteTerminationFeedbackQuestionWiseAnswers = "DeleteTerminationFeedbackQuestionWiseAnswers";

            //Talent Category
            public static string DeleteTalentCategoryDetails = "DeleteTalentCategoryDetails";

            //Talent Sub Category
            public static string DeleteTalentSubCategory = "DeleteTalentSubCategory";

            //Employeewise Talent
            public static string DeleteEmployeeWiseTalent = "DeleteEmployeeWiseTalent";

            //Company Wise Status Wise Processes
            public static string DeleteCompanyWiseStatusWiseProcesses = "DeleteCompanyWiseStatusWiseProcesses";

            //Document Details
            public static string DeleteDocumentDetails = "DeleteDocumentDetails";

            //Employee Wise Documents Details
            public static string DeleteEmployeeWiseDocumentsDetails = "DeleteEmployeeWiseDocumentsDetails";

            //Disciplinary Violation Types
            public static string DeleteDisciplinaryViolationTypes = "DeleteDisciplinaryViolationTypes";

            //Disciplinary Actions To Be Taken
            public static string DeleteDisciplinaryActionsToBeTaken = "DeleteDisciplinaryActionsToBeTaken";

            //Employee Wise Disciplinary Notice
            public static string DeleteEmployeeWiseDisciplinaryNotice = "DeleteEmployeeWiseDisciplinaryNotice";

            //Employee Disciplinary Notice Wise Violations
            public static string DeleteEmployeeDisciplinaryNoticeWiseViolations = "DeleteEmployeeDisciplinaryNoticeWiseViolations";

            //Employee Disciplinary Notice Wise Withness
            public static string DeleteEmployeeDisciplinaryNoticeWiseWithness = "DeleteEmployeeDisciplinaryNoticeWiseWithness";

        }

        #endregion
    }
}
