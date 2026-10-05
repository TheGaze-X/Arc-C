using System;
using System.Runtime.Serialization;
using Il2CppDummyDll;

namespace System.Resources
{
	// Token: 0x020004CE RID: 1230
	[Token(Token = "0x20004CE")]
	[System.Serializable]
	public class MissingSatelliteAssemblyException : System.SystemException
	{
		// Token: 0x0600238A RID: 9098 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600238A")]
		[Address(RVA = "0x4BDAAA0", Offset = "0x4BD96A0", VA = "0x184BDAAA0")]
		public MissingSatelliteAssemblyException()
		{
		}

		// Token: 0x0600238B RID: 9099 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600238B")]
		[Address(RVA = "0x4BDAA60", Offset = "0x4BD9660", VA = "0x184BDAA60")]
		public MissingSatelliteAssemblyException(string message, string cultureName)
		{
		}

		// Token: 0x0600238C RID: 9100 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600238C")]
		[Address(RVA = "0x4AED430", Offset = "0x4AEC030", VA = "0x184AED430")]
		protected MissingSatelliteAssemblyException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
		}

		// Token: 0x04001425 RID: 5157
		[Token(Token = "0x4001425")]
		[FieldOffset(Offset = "0x90")]
		private string _cultureName;
	}
}
