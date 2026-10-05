using System;
using Il2CppDummyDll;

namespace FullInspector.Serializers.FullSerializer
{
	// Token: 0x02007C71 RID: 31857
	[Token(Token = "0x2007C71")]
	public class FullSerializerMetadata : fiISerializerMetadata
	{
		// Token: 0x1700682C RID: 26668
		// (get) Token: 0x0602C832 RID: 182322 RVA: 0x000E0778 File Offset: 0x000DE978
		[Token(Token = "0x1700682C")]
		public Guid SerializerGuid
		{
			[Token(Token = "0x602C832")]
			[Address(RVA = "0x28579B0", Offset = "0x28565B0", VA = "0x1828579B0", Slot = "4")]
			get
			{
				return default(Guid);
			}
		}

		// Token: 0x1700682D RID: 26669
		// (get) Token: 0x0602C833 RID: 182323 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700682D")]
		public Type SerializerType
		{
			[Token(Token = "0x602C833")]
			[Address(RVA = "0x2857A00", Offset = "0x2856600", VA = "0x182857A00", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700682E RID: 26670
		// (get) Token: 0x0602C834 RID: 182324 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700682E")]
		public Type[] SerializationOptInAnnotationTypes
		{
			[Token(Token = "0x602C834")]
			[Address(RVA = "0x2857790", Offset = "0x2856390", VA = "0x182857790", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700682F RID: 26671
		// (get) Token: 0x0602C835 RID: 182325 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700682F")]
		public Type[] SerializationOptOutAnnotationTypes
		{
			[Token(Token = "0x602C835")]
			[Address(RVA = "0x28578D0", Offset = "0x28564D0", VA = "0x1828578D0", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x0602C836 RID: 182326 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C836")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public FullSerializerMetadata()
		{
		}
	}
}
