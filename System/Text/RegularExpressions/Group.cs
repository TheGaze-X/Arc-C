using System;
using Il2CppDummyDll;

namespace System.Text.RegularExpressions
{
	// Token: 0x020000DF RID: 223
	[Token(Token = "0x20000DF")]
	[Serializable]
	public class Group : Capture
	{
		// Token: 0x060004AD RID: 1197 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004AD")]
		[Address(RVA = "0x50EA8A0", Offset = "0x50E94A0", VA = "0x1850EA8A0")]
		internal Group(string text, int[] caps, int capcount, string name)
		{
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x060004AE RID: 1198 RVA: 0x00003B58 File Offset: 0x00001D58
		[Token(Token = "0x170000D7")]
		public bool Success
		{
			[Token(Token = "0x60004AE")]
			[Address(RVA = "0x50EAA10", Offset = "0x50E9610", VA = "0x1850EAA10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x060004AF RID: 1199 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000D8")]
		public CaptureCollection Captures
		{
			[Token(Token = "0x60004AF")]
			[Address(RVA = "0x50EA960", Offset = "0x50E9560", VA = "0x1850EA960")]
			get
			{
				return null;
			}
		}

		// Token: 0x060004B1 RID: 1201 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004B1")]
		[Address(RVA = "0x50EA870", Offset = "0x50E9470", VA = "0x1850EA870")]
		internal Group()
		{
		}

		// Token: 0x0400034D RID: 845
		[Token(Token = "0x400034D")]
		[FieldOffset(Offset = "0x0")]
		internal static readonly Group s_emptyGroup;

		// Token: 0x0400034E RID: 846
		[Token(Token = "0x400034E")]
		[FieldOffset(Offset = "0x20")]
		internal readonly int[] _caps;

		// Token: 0x0400034F RID: 847
		[Token(Token = "0x400034F")]
		[FieldOffset(Offset = "0x28")]
		internal int _capcount;

		// Token: 0x04000350 RID: 848
		[Token(Token = "0x4000350")]
		[FieldOffset(Offset = "0x30")]
		internal CaptureCollection _capcoll;
	}
}
