namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: UsrRealtyEventsSchema

	/// <exclude/>
	public class UsrRealtyEventsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public UsrRealtyEventsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public UsrRealtyEventsSchema(UsrRealtyEventsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("9a722e30-b5d5-4aa3-ae19-bab44de32b68");
			Name = "UsrRealtyEvents";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("e25aba0b-fa68-4cde-82f9-a05fb1fe7f5f");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,146,65,79,194,64,16,133,239,77,252,15,147,198,67,155,152,6,175,162,38,130,104,72,136,26,1,47,198,195,178,29,234,154,237,110,179,187,5,209,240,223,157,237,130,82,224,224,156,154,233,155,111,223,155,140,98,37,218,138,113,132,9,26,195,172,158,187,172,175,213,92,20,181,97,78,104,21,125,71,64,85,91,161,10,24,175,172,195,178,187,211,217,157,50,152,13,148,19,78,160,253,135,36,27,44,80,185,141,242,181,233,174,154,214,72,208,35,10,77,50,230,239,88,178,7,114,8,87,16,79,173,121,70,38,221,42,78,223,154,153,170,158,73,193,129,75,102,45,132,95,71,40,112,1,61,102,241,200,159,6,18,210,237,224,244,130,236,138,28,97,161,69,14,143,106,168,44,26,71,57,18,61,251,64,238,192,162,202,209,156,65,32,246,112,78,161,26,238,141,41,44,96,250,11,252,67,251,154,145,137,108,23,183,229,96,218,109,9,3,23,76,19,136,130,39,161,145,6,125,91,155,35,23,37,147,80,25,193,253,146,194,80,118,143,110,178,170,48,239,107,89,151,234,133,201,26,47,55,210,235,196,47,242,201,235,167,227,219,120,239,109,49,135,36,176,174,225,188,179,173,244,164,37,106,231,242,133,217,208,246,153,226,40,49,39,23,206,212,216,61,16,89,103,252,53,208,185,89,86,224,4,203,74,50,71,166,79,14,148,190,54,73,166,180,45,58,71,69,139,167,91,244,193,70,154,51,41,190,216,76,226,184,33,38,127,151,17,46,42,62,131,184,201,60,180,19,173,123,162,160,148,135,143,180,237,144,235,208,200,238,180,41,153,75,246,108,18,242,60,235,244,78,247,23,230,203,189,27,189,4,133,75,24,124,114,172,188,209,237,248,158,122,29,181,191,214,209,58,250,1,234,196,60,246,129,3,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateValueIsTooBigLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateValueIsTooBigLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("926c3787-e0ca-d642-a9c2-4d6b6114c1ca"),
				Name = "ValueIsTooBig",
				CreatedInPackageId = new Guid("e25aba0b-fa68-4cde-82f9-a05fb1fe7f5f"),
				CreatedInSchemaUId = new Guid("9a722e30-b5d5-4aa3-ae19-bab44de32b68"),
				ModifiedInSchemaUId = new Guid("9a722e30-b5d5-4aa3-ae19-bab44de32b68")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("9a722e30-b5d5-4aa3-ae19-bab44de32b68"));
		}

		#endregion

	}

	#endregion

}

