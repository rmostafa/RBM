using System;
using System.Data;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
using DataAccessLayer.Helpers;
namespace DataAccessLayer.DataAccessComponents.Conference
{
	/// <summary>
	/// This is a Data Access Class  for ConferenceRegisterations table This Class is used to
	/// Insert, Update, Delete, Select, GetByID Operations and dealing with
	/// with the database to retrieve or execute any commands on the ConferenceRegisterations table or related views
	/// Last Modified By: Ramy Mostafa
	/// </summary>
	public class ConferenceRegisterationsDAC : DataAccessComponent
	{
		#region Constructors
        public ConferenceRegisterationsDAC() : base("", "Conference.ConferenceRegisterations") { }
		public ConferenceRegisterationsDAC(string connectionString): base(connectionString){}
		public ConferenceRegisterationsDAC(string connectionStringKey,DatabaseType type): base(connectionStringKey,type){}
		#endregion


		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get all ConferenceRegisterations using Stored Procedure
		/// and return a DataTable containing all ConferenceRegisterations Data
		/// </summary>
		public DataTable GetAllConferenceRegisterations()
		{

			DataSet ds = new DataSet();
			string[] tableNames = new string[1];
			tableNames[0] = "ConferenceRegisterations";
         string query = " select * from GetAllConferenceRegisterations";
         DbCommand command = Database.GetSqlStringCommand(query);
         DataTable table = new DataTable(tableNames[0]);
         table.Merge(this.FromCache(command));
         //Database.LoadDataSet(command,ds,tableNames);
         return table;// ds.Tables["ConferenceRegisterations"];

		}



		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get all ConferenceRegisterations using Stored Procedure
		/// and return a DataTable containing all ConferenceRegisterations Data using a Transaction
		/// </summary>
		public DataTable GetAllConferenceRegisterations(DbTransaction transaction)
		{

			DataSet ds = new DataSet();
			string[] tableNames = new string[1];
			tableNames[0] = "ConferenceRegisterations";
         string query = " select * from GetAllConferenceRegisterations";
         DbCommand command = Database.GetSqlStringCommand(query);
         Database.LoadDataSet(command,ds,tableNames,transaction);
         return ds.Tables["ConferenceRegisterations"];

		}



		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get all ConferenceRegisterations using Stored Procedure
		/// and return a DataTable containing all ConferenceRegisterations Data
		/// </summary>
		public DataTable GetAllConferenceRegisterations(string where)
		{

			DataSet ds = new DataSet();
			string[] tableNames = new string[1];
			tableNames[0] = "ConferenceRegisterations";
         string whereClause = "";
         if(!string.IsNullOrEmpty(where))
             whereClause = " Where " + where;
         string query = " select * from GetAllConferenceRegisterations" + whereClause;
         DbCommand command = Database.GetSqlStringCommand(query);
         DataTable table = new DataTable(tableNames[0]);
         table.Merge(this.FromCache(command));
         //Database.LoadDataSet(command,ds,tableNames);
         return table;// ds.Tables["ConferenceRegisterations"];

		}



		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get all ConferenceRegisterations using Stored Procedure
		/// and return a DataTable containing all ConferenceRegisterations Data using a Transaction
		/// </summary>
		public DataTable GetAllConferenceRegisterations(string where,DbTransaction transaction)
		{

			DataSet ds = new DataSet();
			string[] tableNames = new string[1];
			tableNames[0] = "ConferenceRegisterations";
         string whereClause = "";
         if(!string.IsNullOrEmpty(where))
          whereClause = " Where " + where;
         string query = " select * from GetAllConferenceRegisterations" + whereClause;
         DbCommand command = Database.GetSqlStringCommand(query);
         Database.LoadDataSet(command,ds,tableNames,transaction);
         return ds.Tables["ConferenceRegisterations"];

		}



		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Get a Record ByID From ConferenceRegisterations using Stored Procedure
		/// and return the Record Object
		/// </summary>
		public System.Data.IDataReader GetByIDConferenceRegisterations( int conferenceRegistererId)
		{
                 DbCommand command = Database.GetStoredProcCommand("GetByIDConferenceRegisterations");
				    Database.AddInParameter(command,"ConferenceRegistererId",DbType.Int32,conferenceRegistererId);
				IDataReader reader  = Database.ExecuteReader(command);
				return reader;
		}
        public System.Data.IDataReader GetByPersonIdConferenceIdConferenceRegisterations(int ConferenceId,int PersonId)
        {
            DbCommand command = Database.GetStoredProcCommand("GetByPersonIdConferenceIdConferenceRegisterations");
            Database.AddInParameter(command, "ConferenceId", DbType.Int32, ConferenceId);
            Database.AddInParameter(command, "PersonId", DbType.Int32, PersonId);
            IDataReader reader = Database.ExecuteReader(command);
            return reader;
        }
		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Get a Record ByID From ConferenceRegisterations using Stored Procedure
		/// and return the Record Object
		/// </summary>
		public System.Data.IDataReader GetByIDConferenceRegisterations( int conferenceRegistererId,DbTransaction transaction)
		{
                 DbCommand command = Database.GetStoredProcCommand("GetByIDConferenceRegisterations");
				    Database.AddInParameter(command,"ConferenceRegistererId",DbType.Int32,conferenceRegistererId);
				IDataReader reader  = Database.ExecuteReader(command,transaction);
				return reader;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get Insert a row into ConferenceRegisterations using Stored Procedure
		/// and return the auto number primary key of ConferenceRegisterations inserted row
		/// </summary>
		public bool InsertNewConferenceRegisterations( ref int conferenceRegistererId,  int sponsorId,  int personId,  int conferenceId,  DateTime dateRegistered,  decimal discountAmount,  decimal amountPaid,  string discountReason,  string regitrationCategory,  string licenseNumber,  string address,  string pOBox,  string zipCode,  string city,  string country,  string phoneNumberCountryCode,  string phoneNumberAreaCode,  string phoneNumber,  string faxNumberCountryCode,  string faxNumberAreaCode,  string faxNumber,  string mobileNumberCountryCode,  string mobileNumberAreaCode,  string mobileNumber,  string email,  string academicInformationPosition,  string academicInformationDegree,  bool academicInformationHealthCarePro,  string academicInformationHealthCareProValue,  string hospitalInstituteName,  string hospitalInstituteDepartment,  string hospitalInstituteAddress,  string hospitalInstituteZipCode,  string hospitalInstituteCity,  string hospitalInstituteCountry,  string hospitalInstitutePOBox,  int conferenceRegistrationTypeId,  bool preConferenceWorkShopIncluded,  bool subscribeToNewsLetter,  bool aOAAdministrator,  bool aOARetired,  bool aOAClinicalResearcher,  bool aOABasicResearcher,  bool aOATeacherEducator,  bool aOAIndustryRepresentative,  bool aOAClinicalPractitioner,  bool aOAAlliedHealthProfessional,  bool aOAStudent,  bool aOAOther,  string aOAOtherText,  bool aOAMCNAcuteKidneyInjury,  bool aOAMCNChronicKidneyDisease,  bool aOAMCNHypertension,  bool aOAMCNGlomerulonephritis,  bool aOAMCNNephrolithiasis,  bool aOAMRRTHemodialysis,  bool aOAMRRTPertionealDialysis,  bool aOAMRRTCRRT,  bool aOAMPediatricNephrology,  bool aOAMGenetics,  bool aOAMUrology,  bool aOAMMineralMetabolism,  bool aOAMAnemia,  bool aOAMDiabetes,  bool aOAMImmunology,  bool aOAMPathology,  bool aOAMIterventionalCCN,  bool aOAMOther,  string aOAMOtherText,string SponsorName,decimal DeductedAmount,bool IsActive,bool IsMember,bool IsSelfSponsor)
		{
                 DbCommand command = Database.GetStoredProcCommand("InsertNewConferenceRegisterations");
				Database.AddOutParameter(command,"ConferenceRegistererId",DbType.Int32,Int32.MaxValue);
				Database.AddInParameter(command,"SponsorId",DbType.Int32,sponsorId);
				Database.AddInParameter(command,"PersonId",DbType.Int32,personId);
				Database.AddInParameter(command,"ConferenceId",DbType.Int32,conferenceId);
				Database.AddInParameter(command,"DateRegistered",DbType.DateTime,DateTime.Now);
				Database.AddInParameter(command,"DiscountAmount",DbType.Decimal,discountAmount);
				Database.AddInParameter(command,"AmountPaid",DbType.Decimal,amountPaid);
				Database.AddInParameter(command,"DiscountReason",DbType.String,discountReason);
				Database.AddInParameter(command,"RegitrationCategory",DbType.String,regitrationCategory);
				Database.AddInParameter(command,"LicenseNumber",DbType.String,licenseNumber);
				Database.AddInParameter(command,"Address",DbType.String,address);
				Database.AddInParameter(command,"POBox",DbType.String,pOBox);
				Database.AddInParameter(command,"ZipCode",DbType.String,zipCode);
				Database.AddInParameter(command,"City",DbType.String,city);
				Database.AddInParameter(command,"Country",DbType.String,country);
				Database.AddInParameter(command,"PhoneNumberCountryCode",DbType.String,phoneNumberCountryCode);
				Database.AddInParameter(command,"PhoneNumberAreaCode",DbType.String,phoneNumberAreaCode);
				Database.AddInParameter(command,"PhoneNumber",DbType.String,phoneNumber);
				Database.AddInParameter(command,"FaxNumberCountryCode",DbType.String,faxNumberCountryCode);
				Database.AddInParameter(command,"FaxNumberAreaCode",DbType.String,faxNumberAreaCode);
				Database.AddInParameter(command,"FaxNumber",DbType.String,faxNumber);
				Database.AddInParameter(command,"MobileNumberCountryCode",DbType.String,mobileNumberCountryCode);
				Database.AddInParameter(command,"MobileNumberAreaCode",DbType.String,mobileNumberAreaCode);
				Database.AddInParameter(command,"MobileNumber",DbType.String,mobileNumber);
				Database.AddInParameter(command,"Email",DbType.String,email);
				Database.AddInParameter(command,"AcademicInformationPosition",DbType.String,academicInformationPosition);
				Database.AddInParameter(command,"AcademicInformationDegree",DbType.String,academicInformationDegree);
				Database.AddInParameter(command,"AcademicInformationHealthCarePro",DbType.Boolean,academicInformationHealthCarePro);
				Database.AddInParameter(command,"AcademicInformationHealthCareProValue",DbType.String,academicInformationHealthCareProValue);
				Database.AddInParameter(command,"HospitalInstituteName",DbType.String,hospitalInstituteName);
				Database.AddInParameter(command,"HospitalInstituteDepartment",DbType.String,hospitalInstituteDepartment);
				Database.AddInParameter(command,"HospitalInstituteAddress",DbType.String,hospitalInstituteAddress);
				Database.AddInParameter(command,"HospitalInstituteZipCode",DbType.String,hospitalInstituteZipCode);
				Database.AddInParameter(command,"HospitalInstituteCity",DbType.String,hospitalInstituteCity);
				Database.AddInParameter(command,"HospitalInstituteCountry",DbType.String,hospitalInstituteCountry);
				Database.AddInParameter(command,"HospitalInstitutePOBox",DbType.String,hospitalInstitutePOBox);
				Database.AddInParameter(command,"ConferenceRegistrationTypeId",DbType.Int32,conferenceRegistrationTypeId);
				Database.AddInParameter(command,"PreConferenceWorkShopIncluded",DbType.Boolean,preConferenceWorkShopIncluded);
				Database.AddInParameter(command,"SubscribeToNewsLetter",DbType.Boolean,subscribeToNewsLetter);
				Database.AddInParameter(command,"AOAAdministrator",DbType.Boolean,aOAAdministrator);
				Database.AddInParameter(command,"AOARetired",DbType.Boolean,aOARetired);
				Database.AddInParameter(command,"AOAClinicalResearcher",DbType.Boolean,aOAClinicalResearcher);
				Database.AddInParameter(command,"AOABasicResearcher",DbType.Boolean,aOABasicResearcher);
				Database.AddInParameter(command,"AOATeacherEducator",DbType.Boolean,aOATeacherEducator);
				Database.AddInParameter(command,"AOAIndustryRepresentative",DbType.Boolean,aOAIndustryRepresentative);
				Database.AddInParameter(command,"AOAClinicalPractitioner",DbType.Boolean,aOAClinicalPractitioner);
				Database.AddInParameter(command,"AOAAlliedHealthProfessional",DbType.Boolean,aOAAlliedHealthProfessional);
				Database.AddInParameter(command,"AOAStudent",DbType.Boolean,aOAStudent);
				Database.AddInParameter(command,"AOAOther",DbType.Boolean,aOAOther);
				Database.AddInParameter(command,"AOAOtherText",DbType.String,aOAOtherText);
				Database.AddInParameter(command,"AOAMCNAcuteKidneyInjury",DbType.Boolean,aOAMCNAcuteKidneyInjury);
				Database.AddInParameter(command,"AOAMCNChronicKidneyDisease",DbType.Boolean,aOAMCNChronicKidneyDisease);
				Database.AddInParameter(command,"AOAMCNHypertension",DbType.Boolean,aOAMCNHypertension);
				Database.AddInParameter(command,"AOAMCNGlomerulonephritis",DbType.Boolean,aOAMCNGlomerulonephritis);
				Database.AddInParameter(command,"AOAMCNNephrolithiasis",DbType.Boolean,aOAMCNNephrolithiasis);
				Database.AddInParameter(command,"AOAMRRTHemodialysis",DbType.Boolean,aOAMRRTHemodialysis);
				Database.AddInParameter(command,"AOAMRRTPertionealDialysis",DbType.Boolean,aOAMRRTPertionealDialysis);
				Database.AddInParameter(command,"AOAMRRTCRRT",DbType.Boolean,aOAMRRTCRRT);
				Database.AddInParameter(command,"AOAMPediatricNephrology",DbType.Boolean,aOAMPediatricNephrology);
				Database.AddInParameter(command,"AOAMGenetics",DbType.Boolean,aOAMGenetics);
				Database.AddInParameter(command,"AOAMUrology",DbType.Boolean,aOAMUrology);
				Database.AddInParameter(command,"AOAMMineralMetabolism",DbType.Boolean,aOAMMineralMetabolism);
				Database.AddInParameter(command,"AOAMAnemia",DbType.Boolean,aOAMAnemia);
				Database.AddInParameter(command,"AOAMDiabetes",DbType.Boolean,aOAMDiabetes);
				Database.AddInParameter(command,"AOAMImmunology",DbType.Boolean,aOAMImmunology);
				Database.AddInParameter(command,"AOAMPathology",DbType.Boolean,aOAMPathology);
				Database.AddInParameter(command,"AOAMIterventionalCCN",DbType.Boolean,aOAMIterventionalCCN);
				Database.AddInParameter(command,"AOAMOther",DbType.Boolean,aOAMOther);
				Database.AddInParameter(command,"AOAMOtherText",DbType.String,aOAMOtherText);
                Database.AddInParameter(command, "SponsorName", DbType.String, SponsorName);
                Database.AddInParameter(command, "DeductedAmount", DbType.Decimal, DeductedAmount);
                Database.AddInParameter(command, "IsActive", DbType.Boolean, IsActive);
                Database.AddInParameter(command, "IsMember", DbType.Boolean, IsMember);
                Database.AddInParameter(command, "IsSelfSponsor", DbType.Boolean, IsSelfSponsor);
				bool _status = false;
				if(Database.ExecuteNonQuery(command) > 0)
				{
					_status = true;                 conferenceRegistererId = Convert.ToInt32(Database.GetParameterValue(command, "ConferenceRegistererId"));
				}
				return _status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get Insert a row into ConferenceRegisterations using Stored Procedure
		/// and return the auto number primary key of ConferenceRegisterations inserted row using Transaction
		/// </summary>
        public bool InsertNewConferenceRegisterations(ref int conferenceRegistererId, int sponsorId, int personId, int conferenceId, DateTime dateRegistered, decimal discountAmount, decimal amountPaid, string discountReason, string regitrationCategory, string licenseNumber, string address, string pOBox, string zipCode, string city, string country, string phoneNumberCountryCode, string phoneNumberAreaCode, string phoneNumber, string faxNumberCountryCode, string faxNumberAreaCode, string faxNumber, string mobileNumberCountryCode, string mobileNumberAreaCode, string mobileNumber, string email, string academicInformationPosition, string academicInformationDegree, bool academicInformationHealthCarePro, string academicInformationHealthCareProValue, string hospitalInstituteName, string hospitalInstituteDepartment, string hospitalInstituteAddress, string hospitalInstituteZipCode, string hospitalInstituteCity, string hospitalInstituteCountry, string hospitalInstitutePOBox, int conferenceRegistrationTypeId, bool preConferenceWorkShopIncluded, bool subscribeToNewsLetter, bool aOAAdministrator, bool aOARetired, bool aOAClinicalResearcher, bool aOABasicResearcher, bool aOATeacherEducator, bool aOAIndustryRepresentative, bool aOAClinicalPractitioner, bool aOAAlliedHealthProfessional, bool aOAStudent, bool aOAOther, string aOAOtherText, bool aOAMCNAcuteKidneyInjury, bool aOAMCNChronicKidneyDisease, bool aOAMCNHypertension, bool aOAMCNGlomerulonephritis, bool aOAMCNNephrolithiasis, bool aOAMRRTHemodialysis, bool aOAMRRTPertionealDialysis, bool aOAMRRTCRRT, bool aOAMPediatricNephrology, bool aOAMGenetics, bool aOAMUrology, bool aOAMMineralMetabolism, bool aOAMAnemia, bool aOAMDiabetes, bool aOAMImmunology, bool aOAMPathology, bool aOAMIterventionalCCN, bool aOAMOther, string aOAMOtherText, string SponsorName, decimal DeductedAmount, bool IsActive, bool IsMember, bool IsSelfSponsor, DbTransaction transaction)
		{
                 DbCommand command = Database.GetStoredProcCommand("InsertNewConferenceRegisterations");
				Database.AddOutParameter(command,"ConferenceRegistererId",DbType.Int32,Int32.MaxValue);
				Database.AddInParameter(command,"SponsorId",DbType.Int32,sponsorId);
				Database.AddInParameter(command,"PersonId",DbType.Int32,personId);
				Database.AddInParameter(command,"ConferenceId",DbType.Int32,conferenceId);
				Database.AddInParameter(command,"DateRegistered",DbType.DateTime,dateRegistered);
				Database.AddInParameter(command,"DiscountAmount",DbType.Decimal,discountAmount);
				Database.AddInParameter(command,"AmountPaid",DbType.Decimal,amountPaid);
				Database.AddInParameter(command,"DiscountReason",DbType.String,discountReason);
				Database.AddInParameter(command,"RegitrationCategory",DbType.String,regitrationCategory);
				Database.AddInParameter(command,"LicenseNumber",DbType.String,licenseNumber);
				Database.AddInParameter(command,"Address",DbType.String,address);
				Database.AddInParameter(command,"POBox",DbType.String,pOBox);
				Database.AddInParameter(command,"ZipCode",DbType.String,zipCode);
				Database.AddInParameter(command,"City",DbType.String,city);
				Database.AddInParameter(command,"Country",DbType.String,country);
				Database.AddInParameter(command,"PhoneNumberCountryCode",DbType.String,phoneNumberCountryCode);
				Database.AddInParameter(command,"PhoneNumberAreaCode",DbType.String,phoneNumberAreaCode);
				Database.AddInParameter(command,"PhoneNumber",DbType.String,phoneNumber);
				Database.AddInParameter(command,"FaxNumberCountryCode",DbType.String,faxNumberCountryCode);
				Database.AddInParameter(command,"FaxNumberAreaCode",DbType.String,faxNumberAreaCode);
				Database.AddInParameter(command,"FaxNumber",DbType.String,faxNumber);
				Database.AddInParameter(command,"MobileNumberCountryCode",DbType.String,mobileNumberCountryCode);
				Database.AddInParameter(command,"MobileNumberAreaCode",DbType.String,mobileNumberAreaCode);
				Database.AddInParameter(command,"MobileNumber",DbType.String,mobileNumber);
				Database.AddInParameter(command,"Email",DbType.String,email);
				Database.AddInParameter(command,"AcademicInformationPosition",DbType.String,academicInformationPosition);
				Database.AddInParameter(command,"AcademicInformationDegree",DbType.String,academicInformationDegree);
				Database.AddInParameter(command,"AcademicInformationHealthCarePro",DbType.Boolean,academicInformationHealthCarePro);
				Database.AddInParameter(command,"AcademicInformationHealthCareProValue",DbType.String,academicInformationHealthCareProValue);
				Database.AddInParameter(command,"HospitalInstituteName",DbType.String,hospitalInstituteName);
				Database.AddInParameter(command,"HospitalInstituteDepartment",DbType.String,hospitalInstituteDepartment);
				Database.AddInParameter(command,"HospitalInstituteAddress",DbType.String,hospitalInstituteAddress);
				Database.AddInParameter(command,"HospitalInstituteZipCode",DbType.String,hospitalInstituteZipCode);
				Database.AddInParameter(command,"HospitalInstituteCity",DbType.String,hospitalInstituteCity);
				Database.AddInParameter(command,"HospitalInstituteCountry",DbType.String,hospitalInstituteCountry);
				Database.AddInParameter(command,"HospitalInstitutePOBox",DbType.String,hospitalInstitutePOBox);
				Database.AddInParameter(command,"ConferenceRegistrationTypeId",DbType.Int32,conferenceRegistrationTypeId);
				Database.AddInParameter(command,"PreConferenceWorkShopIncluded",DbType.Boolean,preConferenceWorkShopIncluded);
				Database.AddInParameter(command,"SubscribeToNewsLetter",DbType.Boolean,subscribeToNewsLetter);
				Database.AddInParameter(command,"AOAAdministrator",DbType.Boolean,aOAAdministrator);
				Database.AddInParameter(command,"AOARetired",DbType.Boolean,aOARetired);
				Database.AddInParameter(command,"AOAClinicalResearcher",DbType.Boolean,aOAClinicalResearcher);
				Database.AddInParameter(command,"AOABasicResearcher",DbType.Boolean,aOABasicResearcher);
				Database.AddInParameter(command,"AOATeacherEducator",DbType.Boolean,aOATeacherEducator);
				Database.AddInParameter(command,"AOAIndustryRepresentative",DbType.Boolean,aOAIndustryRepresentative);
				Database.AddInParameter(command,"AOAClinicalPractitioner",DbType.Boolean,aOAClinicalPractitioner);
				Database.AddInParameter(command,"AOAAlliedHealthProfessional",DbType.Boolean,aOAAlliedHealthProfessional);
				Database.AddInParameter(command,"AOAStudent",DbType.Boolean,aOAStudent);
				Database.AddInParameter(command,"AOAOther",DbType.Boolean,aOAOther);
				Database.AddInParameter(command,"AOAOtherText",DbType.String,aOAOtherText);
				Database.AddInParameter(command,"AOAMCNAcuteKidneyInjury",DbType.Boolean,aOAMCNAcuteKidneyInjury);
				Database.AddInParameter(command,"AOAMCNChronicKidneyDisease",DbType.Boolean,aOAMCNChronicKidneyDisease);
				Database.AddInParameter(command,"AOAMCNHypertension",DbType.Boolean,aOAMCNHypertension);
				Database.AddInParameter(command,"AOAMCNGlomerulonephritis",DbType.Boolean,aOAMCNGlomerulonephritis);
				Database.AddInParameter(command,"AOAMCNNephrolithiasis",DbType.Boolean,aOAMCNNephrolithiasis);
				Database.AddInParameter(command,"AOAMRRTHemodialysis",DbType.Boolean,aOAMRRTHemodialysis);
				Database.AddInParameter(command,"AOAMRRTPertionealDialysis",DbType.Boolean,aOAMRRTPertionealDialysis);
				Database.AddInParameter(command,"AOAMRRTCRRT",DbType.Boolean,aOAMRRTCRRT);
				Database.AddInParameter(command,"AOAMPediatricNephrology",DbType.Boolean,aOAMPediatricNephrology);
				Database.AddInParameter(command,"AOAMGenetics",DbType.Boolean,aOAMGenetics);
				Database.AddInParameter(command,"AOAMUrology",DbType.Boolean,aOAMUrology);
				Database.AddInParameter(command,"AOAMMineralMetabolism",DbType.Boolean,aOAMMineralMetabolism);
				Database.AddInParameter(command,"AOAMAnemia",DbType.Boolean,aOAMAnemia);
				Database.AddInParameter(command,"AOAMDiabetes",DbType.Boolean,aOAMDiabetes);
				Database.AddInParameter(command,"AOAMImmunology",DbType.Boolean,aOAMImmunology);
				Database.AddInParameter(command,"AOAMPathology",DbType.Boolean,aOAMPathology);
				Database.AddInParameter(command,"AOAMIterventionalCCN",DbType.Boolean,aOAMIterventionalCCN);
				Database.AddInParameter(command,"AOAMOther",DbType.Boolean,aOAMOther);
				Database.AddInParameter(command,"AOAMOtherText",DbType.String,aOAMOtherText);
                Database.AddInParameter(command, "SponsorName", DbType.String, SponsorName);
                Database.AddInParameter(command, "DeductedAmount", DbType.Decimal, DeductedAmount);
                Database.AddInParameter(command, "IsActive", DbType.Boolean, IsActive);
                Database.AddInParameter(command, "IsMember", DbType.Boolean, IsMember);
                Database.AddInParameter(command, "IsSelfSponsor", DbType.Boolean, IsSelfSponsor);
				bool _status = false;
				if(Database.ExecuteNonQuery(command,transaction) > 0)
				{
					_status = true;                 conferenceRegistererId = Convert.ToInt32(Database.GetParameterValue(command, "ConferenceRegistererId"));
				}
				return _status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get InsertCommand for ConferenceRegisterations using Stored Procedure
		/// and return DbCommand of the ConferenceRegisterations
		/// </summary>
		public DbCommand InsertNewConferenceRegisterationsCommand()
		{
			try
			{
                 DbCommand command = Database.GetStoredProcCommand("InsertNewConferenceRegisterations");

				Database.AddInParameter(command,"SponsorId",DbType.Int32,"SponsorId",DataRowVersion.Current);
				Database.AddInParameter(command,"PersonId",DbType.Int32,"PersonId",DataRowVersion.Current);
				Database.AddInParameter(command,"ConferenceId",DbType.Int32,"ConferenceId",DataRowVersion.Current);
				Database.AddInParameter(command,"DateRegistered",DbType.DateTime,"DateRegistered",DataRowVersion.Current);
				Database.AddInParameter(command,"DiscountAmount",DbType.Decimal,"DiscountAmount",DataRowVersion.Current);
				Database.AddInParameter(command,"AmountPaid",DbType.Decimal,"AmountPaid",DataRowVersion.Current);
				Database.AddInParameter(command,"DiscountReason",DbType.String,"DiscountReason",DataRowVersion.Current);
				Database.AddInParameter(command,"RegitrationCategory",DbType.String,"RegitrationCategory",DataRowVersion.Current);
				Database.AddInParameter(command,"LicenseNumber",DbType.String,"LicenseNumber",DataRowVersion.Current);
				Database.AddInParameter(command,"Address",DbType.String,"Address",DataRowVersion.Current);
				Database.AddInParameter(command,"POBox",DbType.String,"POBox",DataRowVersion.Current);
				Database.AddInParameter(command,"ZipCode",DbType.String,"ZipCode",DataRowVersion.Current);
				Database.AddInParameter(command,"City",DbType.String,"City",DataRowVersion.Current);
				Database.AddInParameter(command,"Country",DbType.String,"Country",DataRowVersion.Current);
				Database.AddInParameter(command,"PhoneNumberCountryCode",DbType.String,"PhoneNumberCountryCode",DataRowVersion.Current);
				Database.AddInParameter(command,"PhoneNumberAreaCode",DbType.String,"PhoneNumberAreaCode",DataRowVersion.Current);
				Database.AddInParameter(command,"PhoneNumber",DbType.String,"PhoneNumber",DataRowVersion.Current);
				Database.AddInParameter(command,"FaxNumberCountryCode",DbType.String,"FaxNumberCountryCode",DataRowVersion.Current);
				Database.AddInParameter(command,"FaxNumberAreaCode",DbType.String,"FaxNumberAreaCode",DataRowVersion.Current);
				Database.AddInParameter(command,"FaxNumber",DbType.String,"FaxNumber",DataRowVersion.Current);
				Database.AddInParameter(command,"MobileNumberCountryCode",DbType.String,"MobileNumberCountryCode",DataRowVersion.Current);
				Database.AddInParameter(command,"MobileNumberAreaCode",DbType.String,"MobileNumberAreaCode",DataRowVersion.Current);
				Database.AddInParameter(command,"MobileNumber",DbType.String,"MobileNumber",DataRowVersion.Current);
				Database.AddInParameter(command,"Email",DbType.String,"Email",DataRowVersion.Current);
				Database.AddInParameter(command,"AcademicInformationPosition",DbType.String,"AcademicInformationPosition",DataRowVersion.Current);
				Database.AddInParameter(command,"AcademicInformationDegree",DbType.String,"AcademicInformationDegree",DataRowVersion.Current);
				Database.AddInParameter(command,"AcademicInformationHealthCarePro",DbType.Boolean,"AcademicInformationHealthCarePro",DataRowVersion.Current);
				Database.AddInParameter(command,"AcademicInformationHealthCareProValue",DbType.String,"AcademicInformationHealthCareProValue",DataRowVersion.Current);
				Database.AddInParameter(command,"HospitalInstituteName",DbType.String,"HospitalInstituteName",DataRowVersion.Current);
				Database.AddInParameter(command,"HospitalInstituteDepartment",DbType.String,"HospitalInstituteDepartment",DataRowVersion.Current);
				Database.AddInParameter(command,"HospitalInstituteAddress",DbType.String,"HospitalInstituteAddress",DataRowVersion.Current);
				Database.AddInParameter(command,"HospitalInstituteZipCode",DbType.String,"HospitalInstituteZipCode",DataRowVersion.Current);
				Database.AddInParameter(command,"HospitalInstituteCity",DbType.String,"HospitalInstituteCity",DataRowVersion.Current);
				Database.AddInParameter(command,"HospitalInstituteCountry",DbType.String,"HospitalInstituteCountry",DataRowVersion.Current);
				Database.AddInParameter(command,"HospitalInstitutePOBox",DbType.String,"HospitalInstitutePOBox",DataRowVersion.Current);
				Database.AddInParameter(command,"ConferenceRegistrationTypeId",DbType.Int32,"ConferenceRegistrationTypeId",DataRowVersion.Current);
				Database.AddInParameter(command,"PreConferenceWorkShopIncluded",DbType.String,"PreConferenceWorkShopIncluded",DataRowVersion.Current);
				Database.AddInParameter(command,"SubscribeToNewsLetter",DbType.Boolean,"SubscribeToNewsLetter",DataRowVersion.Current);
				Database.AddInParameter(command,"AOAAdministrator",DbType.Boolean,"AOAAdministrator",DataRowVersion.Current);
				Database.AddInParameter(command,"AOARetired",DbType.Boolean,"AOARetired",DataRowVersion.Current);
				Database.AddInParameter(command,"AOAClinicalResearcher",DbType.Boolean,"AOAClinicalResearcher",DataRowVersion.Current);
				Database.AddInParameter(command,"AOABasicResearcher",DbType.Boolean,"AOABasicResearcher",DataRowVersion.Current);
				Database.AddInParameter(command,"AOATeacherEducator",DbType.Boolean,"AOATeacherEducator",DataRowVersion.Current);
				Database.AddInParameter(command,"AOAIndustryRepresentative",DbType.Boolean,"AOAIndustryRepresentative",DataRowVersion.Current);
				Database.AddInParameter(command,"AOAClinicalPractitioner",DbType.Boolean,"AOAClinicalPractitioner",DataRowVersion.Current);
				Database.AddInParameter(command,"AOAAlliedHealthProfessional",DbType.Boolean,"AOAAlliedHealthProfessional",DataRowVersion.Current);
				Database.AddInParameter(command,"AOAStudent",DbType.Boolean,"AOAStudent",DataRowVersion.Current);
				Database.AddInParameter(command,"AOAOther",DbType.Boolean,"AOAOther",DataRowVersion.Current);
				Database.AddInParameter(command,"AOAOtherText",DbType.String,"AOAOtherText",DataRowVersion.Current);
				Database.AddInParameter(command,"AOAMCNAcuteKidneyInjury",DbType.Boolean,"AOAMCNAcuteKidneyInjury",DataRowVersion.Current);
				Database.AddInParameter(command,"AOAMCNChronicKidneyDisease",DbType.Boolean,"AOAMCNChronicKidneyDisease",DataRowVersion.Current);
				Database.AddInParameter(command,"AOAMCNHypertension",DbType.Boolean,"AOAMCNHypertension",DataRowVersion.Current);
				Database.AddInParameter(command,"AOAMCNGlomerulonephritis",DbType.Boolean,"AOAMCNGlomerulonephritis",DataRowVersion.Current);
				Database.AddInParameter(command,"AOAMCNNephrolithiasis",DbType.Boolean,"AOAMCNNephrolithiasis",DataRowVersion.Current);
				Database.AddInParameter(command,"AOAMRRTHemodialysis",DbType.Boolean,"AOAMRRTHemodialysis",DataRowVersion.Current);
				Database.AddInParameter(command,"AOAMRRTPertionealDialysis",DbType.Boolean,"AOAMRRTPertionealDialysis",DataRowVersion.Current);
				Database.AddInParameter(command,"AOAMRRTCRRT",DbType.Boolean,"AOAMRRTCRRT",DataRowVersion.Current);
				Database.AddInParameter(command,"AOAMPediatricNephrology",DbType.Boolean,"AOAMPediatricNephrology",DataRowVersion.Current);
				Database.AddInParameter(command,"AOAMGenetics",DbType.Boolean,"AOAMGenetics",DataRowVersion.Current);
				Database.AddInParameter(command,"AOAMUrology",DbType.Boolean,"AOAMUrology",DataRowVersion.Current);
				Database.AddInParameter(command,"AOAMMineralMetabolism",DbType.Boolean,"AOAMMineralMetabolism",DataRowVersion.Current);
				Database.AddInParameter(command,"AOAMAnemia",DbType.Boolean,"AOAMAnemia",DataRowVersion.Current);
				Database.AddInParameter(command,"AOAMDiabetes",DbType.Boolean,"AOAMDiabetes",DataRowVersion.Current);
				Database.AddInParameter(command,"AOAMImmunology",DbType.Boolean,"AOAMImmunology",DataRowVersion.Current);
				Database.AddInParameter(command,"AOAMPathology",DbType.Boolean,"AOAMPathology",DataRowVersion.Current);
				Database.AddInParameter(command,"AOAMIterventionalCCN",DbType.Boolean,"AOAMIterventionalCCN",DataRowVersion.Current);
				Database.AddInParameter(command,"AOAMOther",DbType.Boolean,"AOAMOther",DataRowVersion.Current);
				Database.AddInParameter(command,"AOAMOtherText",DbType.String,"AOAMOtherText",DataRowVersion.Current);
				return command;
			}			catch(Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get Update a row into ConferenceRegisterations using Stored Procedure
		/// </summary>
        public bool UpdateConferenceRegisterations(int sponsorId, int personId, int conferenceId, DateTime dateRegistered, decimal discountAmount, decimal amountPaid, string discountReason, string regitrationCategory, string licenseNumber, string address, string pOBox, string zipCode, string city, string country, string phoneNumberCountryCode, string phoneNumberAreaCode, string phoneNumber, string faxNumberCountryCode, string faxNumberAreaCode, string faxNumber, string mobileNumberCountryCode, string mobileNumberAreaCode, string mobileNumber, string email, string academicInformationPosition, string academicInformationDegree, bool academicInformationHealthCarePro, string academicInformationHealthCareProValue, string hospitalInstituteName, string hospitalInstituteDepartment, string hospitalInstituteAddress, string hospitalInstituteZipCode, string hospitalInstituteCity, string hospitalInstituteCountry, string hospitalInstitutePOBox, int conferenceRegistrationTypeId, bool preConferenceWorkShopIncluded, bool subscribeToNewsLetter, bool aOAAdministrator, bool aOARetired, bool aOAClinicalResearcher, bool aOABasicResearcher, bool aOATeacherEducator, bool aOAIndustryRepresentative, bool aOAClinicalPractitioner, bool aOAAlliedHealthProfessional, bool aOAStudent, bool aOAOther, string aOAOtherText, bool aOAMCNAcuteKidneyInjury, bool aOAMCNChronicKidneyDisease, bool aOAMCNHypertension, bool aOAMCNGlomerulonephritis, bool aOAMCNNephrolithiasis, bool aOAMRRTHemodialysis, bool aOAMRRTPertionealDialysis, bool aOAMRRTCRRT, bool aOAMPediatricNephrology, bool aOAMGenetics, bool aOAMUrology, bool aOAMMineralMetabolism, bool aOAMAnemia, bool aOAMDiabetes, bool aOAMImmunology, bool aOAMPathology, bool aOAMIterventionalCCN, bool aOAMOther, string aOAMOtherText, string SponsorName, decimal DeductedAmount, bool IsActive, bool IsMember, bool IsSelfSponsor, int oldconferenceRegistererId)
		{
                 DbCommand command = Database.GetStoredProcCommand("UpdateConferenceRegisterations");

		    		Database.AddInParameter(command,"SponsorId",DbType.Int32,sponsorId);
		    		Database.AddInParameter(command,"PersonId",DbType.Int32,personId);
		    		Database.AddInParameter(command,"ConferenceId",DbType.Int32,conferenceId);
		    		Database.AddInParameter(command,"DateRegistered",DbType.DateTime,dateRegistered);
		    		Database.AddInParameter(command,"DiscountAmount",DbType.Decimal,discountAmount);
		    		Database.AddInParameter(command,"AmountPaid",DbType.Decimal,amountPaid);
		    		Database.AddInParameter(command,"DiscountReason",DbType.String,discountReason);
		    		Database.AddInParameter(command,"RegitrationCategory",DbType.String,regitrationCategory);
		    		Database.AddInParameter(command,"LicenseNumber",DbType.String,licenseNumber);
		    		Database.AddInParameter(command,"Address",DbType.String,address);
		    		Database.AddInParameter(command,"POBox",DbType.String,pOBox);
		    		Database.AddInParameter(command,"ZipCode",DbType.String,zipCode);
		    		Database.AddInParameter(command,"City",DbType.String,city);
		    		Database.AddInParameter(command,"Country",DbType.String,country);
		    		Database.AddInParameter(command,"PhoneNumberCountryCode",DbType.String,phoneNumberCountryCode);
		    		Database.AddInParameter(command,"PhoneNumberAreaCode",DbType.String,phoneNumberAreaCode);
		    		Database.AddInParameter(command,"PhoneNumber",DbType.String,phoneNumber);
		    		Database.AddInParameter(command,"FaxNumberCountryCode",DbType.String,faxNumberCountryCode);
		    		Database.AddInParameter(command,"FaxNumberAreaCode",DbType.String,faxNumberAreaCode);
		    		Database.AddInParameter(command,"FaxNumber",DbType.String,faxNumber);
		    		Database.AddInParameter(command,"MobileNumberCountryCode",DbType.String,mobileNumberCountryCode);
		    		Database.AddInParameter(command,"MobileNumberAreaCode",DbType.String,mobileNumberAreaCode);
		    		Database.AddInParameter(command,"MobileNumber",DbType.String,mobileNumber);
		    		Database.AddInParameter(command,"Email",DbType.String,email);
		    		Database.AddInParameter(command,"AcademicInformationPosition",DbType.String,academicInformationPosition);
		    		Database.AddInParameter(command,"AcademicInformationDegree",DbType.String,academicInformationDegree);
		    		Database.AddInParameter(command,"AcademicInformationHealthCarePro",DbType.Boolean,academicInformationHealthCarePro);
		    		Database.AddInParameter(command,"AcademicInformationHealthCareProValue",DbType.String,academicInformationHealthCareProValue);
		    		Database.AddInParameter(command,"HospitalInstituteName",DbType.String,hospitalInstituteName);
		    		Database.AddInParameter(command,"HospitalInstituteDepartment",DbType.String,hospitalInstituteDepartment);
		    		Database.AddInParameter(command,"HospitalInstituteAddress",DbType.String,hospitalInstituteAddress);
		    		Database.AddInParameter(command,"HospitalInstituteZipCode",DbType.String,hospitalInstituteZipCode);
		    		Database.AddInParameter(command,"HospitalInstituteCity",DbType.String,hospitalInstituteCity);
		    		Database.AddInParameter(command,"HospitalInstituteCountry",DbType.String,hospitalInstituteCountry);
		    		Database.AddInParameter(command,"HospitalInstitutePOBox",DbType.String,hospitalInstitutePOBox);
		    		Database.AddInParameter(command,"ConferenceRegistrationTypeId",DbType.Int32,conferenceRegistrationTypeId);
		    		Database.AddInParameter(command,"PreConferenceWorkShopIncluded",DbType.Boolean,preConferenceWorkShopIncluded);
		    		Database.AddInParameter(command,"SubscribeToNewsLetter",DbType.Boolean,subscribeToNewsLetter);
		    		Database.AddInParameter(command,"AOAAdministrator",DbType.Boolean,aOAAdministrator);
		    		Database.AddInParameter(command,"AOARetired",DbType.Boolean,aOARetired);
		    		Database.AddInParameter(command,"AOAClinicalResearcher",DbType.Boolean,aOAClinicalResearcher);
		    		Database.AddInParameter(command,"AOABasicResearcher",DbType.Boolean,aOABasicResearcher);
		    		Database.AddInParameter(command,"AOATeacherEducator",DbType.Boolean,aOATeacherEducator);
		    		Database.AddInParameter(command,"AOAIndustryRepresentative",DbType.Boolean,aOAIndustryRepresentative);
		    		Database.AddInParameter(command,"AOAClinicalPractitioner",DbType.Boolean,aOAClinicalPractitioner);
		    		Database.AddInParameter(command,"AOAAlliedHealthProfessional",DbType.Boolean,aOAAlliedHealthProfessional);
		    		Database.AddInParameter(command,"AOAStudent",DbType.Boolean,aOAStudent);
		    		Database.AddInParameter(command,"AOAOther",DbType.Boolean,aOAOther);
		    		Database.AddInParameter(command,"AOAOtherText",DbType.String,aOAOtherText);
		    		Database.AddInParameter(command,"AOAMCNAcuteKidneyInjury",DbType.Boolean,aOAMCNAcuteKidneyInjury);
		    		Database.AddInParameter(command,"AOAMCNChronicKidneyDisease",DbType.Boolean,aOAMCNChronicKidneyDisease);
		    		Database.AddInParameter(command,"AOAMCNHypertension",DbType.Boolean,aOAMCNHypertension);
		    		Database.AddInParameter(command,"AOAMCNGlomerulonephritis",DbType.Boolean,aOAMCNGlomerulonephritis);
		    		Database.AddInParameter(command,"AOAMCNNephrolithiasis",DbType.Boolean,aOAMCNNephrolithiasis);
		    		Database.AddInParameter(command,"AOAMRRTHemodialysis",DbType.Boolean,aOAMRRTHemodialysis);
		    		Database.AddInParameter(command,"AOAMRRTPertionealDialysis",DbType.Boolean,aOAMRRTPertionealDialysis);
		    		Database.AddInParameter(command,"AOAMRRTCRRT",DbType.Boolean,aOAMRRTCRRT);
		    		Database.AddInParameter(command,"AOAMPediatricNephrology",DbType.Boolean,aOAMPediatricNephrology);
		    		Database.AddInParameter(command,"AOAMGenetics",DbType.Boolean,aOAMGenetics);
		    		Database.AddInParameter(command,"AOAMUrology",DbType.Boolean,aOAMUrology);
		    		Database.AddInParameter(command,"AOAMMineralMetabolism",DbType.Boolean,aOAMMineralMetabolism);
		    		Database.AddInParameter(command,"AOAMAnemia",DbType.Boolean,aOAMAnemia);
		    		Database.AddInParameter(command,"AOAMDiabetes",DbType.Boolean,aOAMDiabetes);
		    		Database.AddInParameter(command,"AOAMImmunology",DbType.Boolean,aOAMImmunology);
		    		Database.AddInParameter(command,"AOAMPathology",DbType.Boolean,aOAMPathology);
		    		Database.AddInParameter(command,"AOAMIterventionalCCN",DbType.Boolean,aOAMIterventionalCCN);
		    		Database.AddInParameter(command,"AOAMOther",DbType.Boolean,aOAMOther);
		    		Database.AddInParameter(command,"AOAMOtherText",DbType.String,aOAMOtherText);
                    Database.AddInParameter(command, "SponsorName", DbType.String, SponsorName);
                    Database.AddInParameter(command, "DeductedAmount", DbType.Decimal, DeductedAmount);
                    Database.AddInParameter(command, "IsActive", DbType.Boolean, IsActive);
                    Database.AddInParameter(command, "IsMember", DbType.Boolean, IsMember);
                    Database.AddInParameter(command, "IsSelfSponsor", DbType.Boolean, IsSelfSponsor);
				Database.AddInParameter(command,"oldConferenceRegistererId",DbType.Int32,oldconferenceRegistererId);

				bool _status = false;
				if(Database.ExecuteNonQuery(command) > 0)
				{
					_status = true;
				}
				return _status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get Update a row into ConferenceRegisterations using Stored Procedure By Transaction
		/// </summary>
        public bool UpdateConferenceRegisterations(int sponsorId, int personId, int conferenceId, DateTime dateRegistered, decimal discountAmount, decimal amountPaid, string discountReason, string regitrationCategory, string licenseNumber, string address, string pOBox, string zipCode, string city, string country, string phoneNumberCountryCode, string phoneNumberAreaCode, string phoneNumber, string faxNumberCountryCode, string faxNumberAreaCode, string faxNumber, string mobileNumberCountryCode, string mobileNumberAreaCode, string mobileNumber, string email, string academicInformationPosition, string academicInformationDegree, bool academicInformationHealthCarePro, string academicInformationHealthCareProValue, string hospitalInstituteName, string hospitalInstituteDepartment, string hospitalInstituteAddress, string hospitalInstituteZipCode, string hospitalInstituteCity, string hospitalInstituteCountry, string hospitalInstitutePOBox, int conferenceRegistrationTypeId, bool preConferenceWorkShopIncluded, bool subscribeToNewsLetter, bool aOAAdministrator, bool aOARetired, bool aOAClinicalResearcher, bool aOABasicResearcher, bool aOATeacherEducator, bool aOAIndustryRepresentative, bool aOAClinicalPractitioner, bool aOAAlliedHealthProfessional, bool aOAStudent, bool aOAOther, string aOAOtherText, bool aOAMCNAcuteKidneyInjury, bool aOAMCNChronicKidneyDisease, bool aOAMCNHypertension, bool aOAMCNGlomerulonephritis, bool aOAMCNNephrolithiasis, bool aOAMRRTHemodialysis, bool aOAMRRTPertionealDialysis, bool aOAMRRTCRRT, bool aOAMPediatricNephrology, bool aOAMGenetics, bool aOAMUrology, bool aOAMMineralMetabolism, bool aOAMAnemia, bool aOAMDiabetes, bool aOAMImmunology, bool aOAMPathology, bool aOAMIterventionalCCN, bool aOAMOther, string aOAMOtherText, string SponsorName, decimal DeductedAmount, bool IsActive, bool IsMember, bool IsSelfSponsor, int oldconferenceRegistererId, DbTransaction transaction)
		{
                 DbCommand command = Database.GetStoredProcCommand("UpdateConferenceRegisterations");

		    		Database.AddInParameter(command,"SponsorId",DbType.Int32,sponsorId);
		    		Database.AddInParameter(command,"PersonId",DbType.Int32,personId);
		    		Database.AddInParameter(command,"ConferenceId",DbType.Int32,conferenceId);
		    		Database.AddInParameter(command,"DateRegistered",DbType.DateTime,dateRegistered);
		    		Database.AddInParameter(command,"DiscountAmount",DbType.Decimal,discountAmount);
		    		Database.AddInParameter(command,"AmountPaid",DbType.Decimal,amountPaid);
		    		Database.AddInParameter(command,"DiscountReason",DbType.String,discountReason);
		    		Database.AddInParameter(command,"RegitrationCategory",DbType.String,regitrationCategory);
		    		Database.AddInParameter(command,"LicenseNumber",DbType.String,licenseNumber);
		    		Database.AddInParameter(command,"Address",DbType.String,address);
		    		Database.AddInParameter(command,"POBox",DbType.String,pOBox);
		    		Database.AddInParameter(command,"ZipCode",DbType.String,zipCode);
		    		Database.AddInParameter(command,"City",DbType.String,city);
		    		Database.AddInParameter(command,"Country",DbType.String,country);
		    		Database.AddInParameter(command,"PhoneNumberCountryCode",DbType.String,phoneNumberCountryCode);
		    		Database.AddInParameter(command,"PhoneNumberAreaCode",DbType.String,phoneNumberAreaCode);
		    		Database.AddInParameter(command,"PhoneNumber",DbType.String,phoneNumber);
		    		Database.AddInParameter(command,"FaxNumberCountryCode",DbType.String,faxNumberCountryCode);
		    		Database.AddInParameter(command,"FaxNumberAreaCode",DbType.String,faxNumberAreaCode);
		    		Database.AddInParameter(command,"FaxNumber",DbType.String,faxNumber);
		    		Database.AddInParameter(command,"MobileNumberCountryCode",DbType.String,mobileNumberCountryCode);
		    		Database.AddInParameter(command,"MobileNumberAreaCode",DbType.String,mobileNumberAreaCode);
		    		Database.AddInParameter(command,"MobileNumber",DbType.String,mobileNumber);
		    		Database.AddInParameter(command,"Email",DbType.String,email);
		    		Database.AddInParameter(command,"AcademicInformationPosition",DbType.String,academicInformationPosition);
		    		Database.AddInParameter(command,"AcademicInformationDegree",DbType.String,academicInformationDegree);
		    		Database.AddInParameter(command,"AcademicInformationHealthCarePro",DbType.Boolean,academicInformationHealthCarePro);
		    		Database.AddInParameter(command,"AcademicInformationHealthCareProValue",DbType.String,academicInformationHealthCareProValue);
		    		Database.AddInParameter(command,"HospitalInstituteName",DbType.String,hospitalInstituteName);
		    		Database.AddInParameter(command,"HospitalInstituteDepartment",DbType.String,hospitalInstituteDepartment);
		    		Database.AddInParameter(command,"HospitalInstituteAddress",DbType.String,hospitalInstituteAddress);
		    		Database.AddInParameter(command,"HospitalInstituteZipCode",DbType.String,hospitalInstituteZipCode);
		    		Database.AddInParameter(command,"HospitalInstituteCity",DbType.String,hospitalInstituteCity);
		    		Database.AddInParameter(command,"HospitalInstituteCountry",DbType.String,hospitalInstituteCountry);
		    		Database.AddInParameter(command,"HospitalInstitutePOBox",DbType.String,hospitalInstitutePOBox);
		    		Database.AddInParameter(command,"ConferenceRegistrationTypeId",DbType.Int32,conferenceRegistrationTypeId);
		    		Database.AddInParameter(command,"PreConferenceWorkShopIncluded",DbType.Boolean,preConferenceWorkShopIncluded);
		    		Database.AddInParameter(command,"SubscribeToNewsLetter",DbType.Boolean,subscribeToNewsLetter);
		    		Database.AddInParameter(command,"AOAAdministrator",DbType.Boolean,aOAAdministrator);
		    		Database.AddInParameter(command,"AOARetired",DbType.Boolean,aOARetired);
		    		Database.AddInParameter(command,"AOAClinicalResearcher",DbType.Boolean,aOAClinicalResearcher);
		    		Database.AddInParameter(command,"AOABasicResearcher",DbType.Boolean,aOABasicResearcher);
		    		Database.AddInParameter(command,"AOATeacherEducator",DbType.Boolean,aOATeacherEducator);
		    		Database.AddInParameter(command,"AOAIndustryRepresentative",DbType.Boolean,aOAIndustryRepresentative);
		    		Database.AddInParameter(command,"AOAClinicalPractitioner",DbType.Boolean,aOAClinicalPractitioner);
		    		Database.AddInParameter(command,"AOAAlliedHealthProfessional",DbType.Boolean,aOAAlliedHealthProfessional);
		    		Database.AddInParameter(command,"AOAStudent",DbType.Boolean,aOAStudent);
		    		Database.AddInParameter(command,"AOAOther",DbType.Boolean,aOAOther);
		    		Database.AddInParameter(command,"AOAOtherText",DbType.String,aOAOtherText);
		    		Database.AddInParameter(command,"AOAMCNAcuteKidneyInjury",DbType.Boolean,aOAMCNAcuteKidneyInjury);
		    		Database.AddInParameter(command,"AOAMCNChronicKidneyDisease",DbType.Boolean,aOAMCNChronicKidneyDisease);
		    		Database.AddInParameter(command,"AOAMCNHypertension",DbType.Boolean,aOAMCNHypertension);
		    		Database.AddInParameter(command,"AOAMCNGlomerulonephritis",DbType.Boolean,aOAMCNGlomerulonephritis);
		    		Database.AddInParameter(command,"AOAMCNNephrolithiasis",DbType.Boolean,aOAMCNNephrolithiasis);
		    		Database.AddInParameter(command,"AOAMRRTHemodialysis",DbType.Boolean,aOAMRRTHemodialysis);
		    		Database.AddInParameter(command,"AOAMRRTPertionealDialysis",DbType.Boolean,aOAMRRTPertionealDialysis);
		    		Database.AddInParameter(command,"AOAMRRTCRRT",DbType.Boolean,aOAMRRTCRRT);
		    		Database.AddInParameter(command,"AOAMPediatricNephrology",DbType.Boolean,aOAMPediatricNephrology);
		    		Database.AddInParameter(command,"AOAMGenetics",DbType.Boolean,aOAMGenetics);
		    		Database.AddInParameter(command,"AOAMUrology",DbType.Boolean,aOAMUrology);
		    		Database.AddInParameter(command,"AOAMMineralMetabolism",DbType.Boolean,aOAMMineralMetabolism);
		    		Database.AddInParameter(command,"AOAMAnemia",DbType.Boolean,aOAMAnemia);
		    		Database.AddInParameter(command,"AOAMDiabetes",DbType.Boolean,aOAMDiabetes);
		    		Database.AddInParameter(command,"AOAMImmunology",DbType.Boolean,aOAMImmunology);
		    		Database.AddInParameter(command,"AOAMPathology",DbType.Boolean,aOAMPathology);
		    		Database.AddInParameter(command,"AOAMIterventionalCCN",DbType.Boolean,aOAMIterventionalCCN);
		    		Database.AddInParameter(command,"AOAMOther",DbType.Boolean,aOAMOther);
		    		Database.AddInParameter(command,"AOAMOtherText",DbType.String,aOAMOtherText);
                    Database.AddInParameter(command, "SponsorName", DbType.String, SponsorName);
                    Database.AddInParameter(command, "DeductedAmount", DbType.Decimal, DeductedAmount);
                    Database.AddInParameter(command, "IsActive", DbType.Boolean, IsActive);
                    Database.AddInParameter(command, "IsMember", DbType.Boolean, IsMember);
                    Database.AddInParameter(command, "IsSelfSponsor", DbType.Boolean, IsSelfSponsor);
				Database.AddInParameter(command,"oldConferenceRegistererId",DbType.Int32,oldconferenceRegistererId);

				bool _status = false;
				if(Database.ExecuteNonQuery(command,transaction) > 0)
				{
					_status = true;
				}
				return _status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to get UpdateCommand from ConferenceRegisterations using Stored Procedure
		/// </summary>
		public DbCommand UpdateConferenceRegisterationsCommand()
		{
			try
			{
                 DbCommand command = Database.GetStoredProcCommand("UpdateConferenceRegisterations");

		    		Database.AddInParameter(command,"SponsorId",DbType.Int32,"SponsorId",DataRowVersion.Current);
		    		Database.AddInParameter(command,"PersonId",DbType.Int32,"PersonId",DataRowVersion.Current);
		    		Database.AddInParameter(command,"ConferenceId",DbType.Int32,"ConferenceId",DataRowVersion.Current);
		    		Database.AddInParameter(command,"DateRegistered",DbType.DateTime,"DateRegistered",DataRowVersion.Current);
		    		Database.AddInParameter(command,"DiscountAmount",DbType.Decimal,"DiscountAmount",DataRowVersion.Current);
		    		Database.AddInParameter(command,"AmountPaid",DbType.Decimal,"AmountPaid",DataRowVersion.Current);
		    		Database.AddInParameter(command,"DiscountReason",DbType.String,"DiscountReason",DataRowVersion.Current);
		    		Database.AddInParameter(command,"RegitrationCategory",DbType.String,"RegitrationCategory",DataRowVersion.Current);
		    		Database.AddInParameter(command,"LicenseNumber",DbType.String,"LicenseNumber",DataRowVersion.Current);
		    		Database.AddInParameter(command,"Address",DbType.String,"Address",DataRowVersion.Current);
		    		Database.AddInParameter(command,"POBox",DbType.String,"POBox",DataRowVersion.Current);
		    		Database.AddInParameter(command,"ZipCode",DbType.String,"ZipCode",DataRowVersion.Current);
		    		Database.AddInParameter(command,"City",DbType.String,"City",DataRowVersion.Current);
		    		Database.AddInParameter(command,"Country",DbType.String,"Country",DataRowVersion.Current);
		    		Database.AddInParameter(command,"PhoneNumberCountryCode",DbType.String,"PhoneNumberCountryCode",DataRowVersion.Current);
		    		Database.AddInParameter(command,"PhoneNumberAreaCode",DbType.String,"PhoneNumberAreaCode",DataRowVersion.Current);
		    		Database.AddInParameter(command,"PhoneNumber",DbType.String,"PhoneNumber",DataRowVersion.Current);
		    		Database.AddInParameter(command,"FaxNumberCountryCode",DbType.String,"FaxNumberCountryCode",DataRowVersion.Current);
		    		Database.AddInParameter(command,"FaxNumberAreaCode",DbType.String,"FaxNumberAreaCode",DataRowVersion.Current);
		    		Database.AddInParameter(command,"FaxNumber",DbType.String,"FaxNumber",DataRowVersion.Current);
		    		Database.AddInParameter(command,"MobileNumberCountryCode",DbType.String,"MobileNumberCountryCode",DataRowVersion.Current);
		    		Database.AddInParameter(command,"MobileNumberAreaCode",DbType.String,"MobileNumberAreaCode",DataRowVersion.Current);
		    		Database.AddInParameter(command,"MobileNumber",DbType.String,"MobileNumber",DataRowVersion.Current);
		    		Database.AddInParameter(command,"Email",DbType.String,"Email",DataRowVersion.Current);
		    		Database.AddInParameter(command,"AcademicInformationPosition",DbType.String,"AcademicInformationPosition",DataRowVersion.Current);
		    		Database.AddInParameter(command,"AcademicInformationDegree",DbType.String,"AcademicInformationDegree",DataRowVersion.Current);
		    		Database.AddInParameter(command,"AcademicInformationHealthCarePro",DbType.Boolean,"AcademicInformationHealthCarePro",DataRowVersion.Current);
		    		Database.AddInParameter(command,"AcademicInformationHealthCareProValue",DbType.String,"AcademicInformationHealthCareProValue",DataRowVersion.Current);
		    		Database.AddInParameter(command,"HospitalInstituteName",DbType.String,"HospitalInstituteName",DataRowVersion.Current);
		    		Database.AddInParameter(command,"HospitalInstituteDepartment",DbType.String,"HospitalInstituteDepartment",DataRowVersion.Current);
		    		Database.AddInParameter(command,"HospitalInstituteAddress",DbType.String,"HospitalInstituteAddress",DataRowVersion.Current);
		    		Database.AddInParameter(command,"HospitalInstituteZipCode",DbType.String,"HospitalInstituteZipCode",DataRowVersion.Current);
		    		Database.AddInParameter(command,"HospitalInstituteCity",DbType.String,"HospitalInstituteCity",DataRowVersion.Current);
		    		Database.AddInParameter(command,"HospitalInstituteCountry",DbType.String,"HospitalInstituteCountry",DataRowVersion.Current);
		    		Database.AddInParameter(command,"HospitalInstitutePOBox",DbType.String,"HospitalInstitutePOBox",DataRowVersion.Current);
		    		Database.AddInParameter(command,"ConferenceRegistrationTypeId",DbType.Int32,"ConferenceRegistrationTypeId",DataRowVersion.Current);
		    		Database.AddInParameter(command,"PreConferenceWorkShopIncluded",DbType.String,"PreConferenceWorkShopIncluded",DataRowVersion.Current);
		    		Database.AddInParameter(command,"SubscribeToNewsLetter",DbType.Boolean,"SubscribeToNewsLetter",DataRowVersion.Current);
		    		Database.AddInParameter(command,"AOAAdministrator",DbType.Boolean,"AOAAdministrator",DataRowVersion.Current);
		    		Database.AddInParameter(command,"AOARetired",DbType.Boolean,"AOARetired",DataRowVersion.Current);
		    		Database.AddInParameter(command,"AOAClinicalResearcher",DbType.Boolean,"AOAClinicalResearcher",DataRowVersion.Current);
		    		Database.AddInParameter(command,"AOABasicResearcher",DbType.Boolean,"AOABasicResearcher",DataRowVersion.Current);
		    		Database.AddInParameter(command,"AOATeacherEducator",DbType.Boolean,"AOATeacherEducator",DataRowVersion.Current);
		    		Database.AddInParameter(command,"AOAIndustryRepresentative",DbType.Boolean,"AOAIndustryRepresentative",DataRowVersion.Current);
		    		Database.AddInParameter(command,"AOAClinicalPractitioner",DbType.Boolean,"AOAClinicalPractitioner",DataRowVersion.Current);
		    		Database.AddInParameter(command,"AOAAlliedHealthProfessional",DbType.Boolean,"AOAAlliedHealthProfessional",DataRowVersion.Current);
		    		Database.AddInParameter(command,"AOAStudent",DbType.Boolean,"AOAStudent",DataRowVersion.Current);
		    		Database.AddInParameter(command,"AOAOther",DbType.Boolean,"AOAOther",DataRowVersion.Current);
		    		Database.AddInParameter(command,"AOAOtherText",DbType.String,"AOAOtherText",DataRowVersion.Current);
		    		Database.AddInParameter(command,"AOAMCNAcuteKidneyInjury",DbType.Boolean,"AOAMCNAcuteKidneyInjury",DataRowVersion.Current);
		    		Database.AddInParameter(command,"AOAMCNChronicKidneyDisease",DbType.Boolean,"AOAMCNChronicKidneyDisease",DataRowVersion.Current);
		    		Database.AddInParameter(command,"AOAMCNHypertension",DbType.Boolean,"AOAMCNHypertension",DataRowVersion.Current);
		    		Database.AddInParameter(command,"AOAMCNGlomerulonephritis",DbType.Boolean,"AOAMCNGlomerulonephritis",DataRowVersion.Current);
		    		Database.AddInParameter(command,"AOAMCNNephrolithiasis",DbType.Boolean,"AOAMCNNephrolithiasis",DataRowVersion.Current);
		    		Database.AddInParameter(command,"AOAMRRTHemodialysis",DbType.Boolean,"AOAMRRTHemodialysis",DataRowVersion.Current);
		    		Database.AddInParameter(command,"AOAMRRTPertionealDialysis",DbType.Boolean,"AOAMRRTPertionealDialysis",DataRowVersion.Current);
		    		Database.AddInParameter(command,"AOAMRRTCRRT",DbType.Boolean,"AOAMRRTCRRT",DataRowVersion.Current);
		    		Database.AddInParameter(command,"AOAMPediatricNephrology",DbType.Boolean,"AOAMPediatricNephrology",DataRowVersion.Current);
		    		Database.AddInParameter(command,"AOAMGenetics",DbType.Boolean,"AOAMGenetics",DataRowVersion.Current);
		    		Database.AddInParameter(command,"AOAMUrology",DbType.Boolean,"AOAMUrology",DataRowVersion.Current);
		    		Database.AddInParameter(command,"AOAMMineralMetabolism",DbType.Boolean,"AOAMMineralMetabolism",DataRowVersion.Current);
		    		Database.AddInParameter(command,"AOAMAnemia",DbType.Boolean,"AOAMAnemia",DataRowVersion.Current);
		    		Database.AddInParameter(command,"AOAMDiabetes",DbType.Boolean,"AOAMDiabetes",DataRowVersion.Current);
		    		Database.AddInParameter(command,"AOAMImmunology",DbType.Boolean,"AOAMImmunology",DataRowVersion.Current);
		    		Database.AddInParameter(command,"AOAMPathology",DbType.Boolean,"AOAMPathology",DataRowVersion.Current);
		    		Database.AddInParameter(command,"AOAMIterventionalCCN",DbType.Boolean,"AOAMIterventionalCCN",DataRowVersion.Current);
		    		Database.AddInParameter(command,"AOAMOther",DbType.Boolean,"AOAMOther",DataRowVersion.Current);
		    		Database.AddInParameter(command,"AOAMOtherText",DbType.String,"AOAMOtherText",DataRowVersion.Current);
				Database.AddInParameter(command,"oldConferenceRegistererId",DbType.Int32,"ConferenceRegistererId",DataRowVersion.Current);

				return command;
			}			catch(Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Delete a row From ConferenceRegisterations using Stored Procedure
		/// and return boolean Whether the record was deleted or not
		/// </summary>
		public bool DeleteConferenceRegisterations( int conferenceRegistererId)
		{
           DbCommand command = Database.GetStoredProcCommand("DeleteConferenceRegisterations");
			Database.AddInParameter(command,"ConferenceRegistererId",DbType.Int32,conferenceRegistererId);
			bool status = false;
			if(Database.ExecuteNonQuery(command) > 0)
			{
				status = true;
			}
			return status;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Get a Delete Command From ConferenceRegisterations Delete Stored Procedure
		/// and return DbCommand Init the delete command
		/// </summary>
		public DbCommand DeleteConferenceRegisterationsCommand()
		{
			try
			{
                DbCommand command = Database.GetStoredProcCommand("DeleteConferenceRegisterations");
				Database.AddInParameter(command,"ConferenceRegistererId",DbType.Int32,"ConferenceRegistererId",DataRowVersion.Current);
				return command;
			}			catch(Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Update Dataset for table ConferenceRegisterations using Stored Procedure
		/// and return number of rows effected of the ConferenceRegisterations
		/// </summary>
		public int UpdateDataset(System.Data.DataSet dataset)
		{
          int rowsAffected = 0;
          rowsAffected = Database.UpdateDataSet(dataset,"ConferenceRegisterations",InsertNewConferenceRegisterationsCommand(),UpdateConferenceRegisterationsCommand(),DeleteConferenceRegisterationsCommand(), Microsoft.Practices.EnterpriseLibrary.Data.UpdateBehavior.Standard);
          return rowsAffected;
		}

		/// <summary>
		/// This Function Uses the Microsoft.Practices.EnterpriseLibrary.Data to Update Dataset for table ConferenceRegisterations using Stored Procedure
		/// and return number of rows effected of the ConferenceRegisterations
		/// </summary>
		public int UpdateDataset(System.Data.DataSet dataset,DbTransaction transaction)
		{
          int rowsAffected = 0;
          rowsAffected = Database.UpdateDataSet(dataset,"ConferenceRegisterations",InsertNewConferenceRegisterationsCommand(),UpdateConferenceRegisterationsCommand(),DeleteConferenceRegisterationsCommand(), transaction);
          return rowsAffected;
		}


	}
}
