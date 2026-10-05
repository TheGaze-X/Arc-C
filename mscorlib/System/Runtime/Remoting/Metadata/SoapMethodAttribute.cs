using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System.Runtime.Remoting.Metadata
{
	// Token: 0x020003B4 RID: 948
	[Token(Token = "0x20003B4")]
	[System.AttributeUsage(System.AttributeTargets.Method)]
	[System.Runtime.InteropServices.ComVisible(true)]
	public sealed class SoapMethodAttribute : SoapAttribute
	{
		// Token: 0x06001E21 RID: 7713 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E21")]
		[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
		public SoapMethodAttribute()
		{
		}

		// Token: 0x17000396 RID: 918
		// (get) Token: 0x06001E22 RID: 7714 RVA: 0x00012D50 File Offset: 0x00010F50
		[Token(Token = "0x17000396")]
		public override bool UseAttribute
		{
			[Token(Token = "0x6001E22")]
			[Address(RVA = "0x16647A0", Offset = "0x16633A0", VA = "0x1816647A0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000397 RID: 919
		// (get) Token: 0x06001E23 RID: 7715 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000397")]
		public override string XmlNamespace
		{
			[Token(Token = "0x6001E23")]
			[Address(RVA = "0x5EC460", Offset = "0x5EB060", VA = "0x1805EC460", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001E24 RID: 7716 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E24")]
		[Address(RVA = "0x4B8EB40", Offset = "0x4B8D740", VA = "0x184B8EB40", Slot = "9")]
		internal override void SetReflectionObject(object reflectionObject)
		{
		}

		// Token: 0x04000FF8 RID: 4088
		[Token(Token = "0x4000FF8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string _responseElement;

		// Token: 0x04000FF9 RID: 4089
		[Token(Token = "0x4000FF9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private string _responseNamespace;

		// Token: 0x04000FFA RID: 4090
		[Token(Token = "0x4000FFA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private string _returnElement;

		// Token: 0x04000FFB RID: 4091
		[Token(Token = "0x4000FFB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private string _soapAction;

		// Token: 0x04000FFC RID: 4092
		[Token(Token = "0x4000FFC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool _useAttribute;

		// Token: 0x04000FFD RID: 4093
		[Token(Token = "0x4000FFD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private string _namespace;
	}
}
