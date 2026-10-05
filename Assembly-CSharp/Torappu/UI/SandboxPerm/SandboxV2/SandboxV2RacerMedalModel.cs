using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004366 RID: 17254
	[Token(Token = "0x2004366")]
	public class SandboxV2RacerMedalModel : IHotfixable, IComparable
	{
		// Token: 0x0601A79E RID: 108446 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A79E")]
		[Address(RVA = "0x1396710", Offset = "0x1395310", VA = "0x181396710")]
		public SandboxV2RacerMedalModel(string topicId, SandboxV2RacerMedalInfo medalInfo)
		{
		}

		// Token: 0x0601A79F RID: 108447 RVA: 0x000A1EB0 File Offset: 0x000A00B0
		[Token(Token = "0x601A79F")]
		[Address(RVA = "0x1396610", Offset = "0x1395210", VA = "0x181396610", Slot = "4")]
		public int CompareTo(object obj)
		{
			return 0;
		}

		// Token: 0x04021B0A RID: 137994
		[Token(Token = "0x4021B0A")]
		[FieldOffset(Offset = "0x10")]
		public string name;

		// Token: 0x04021B0B RID: 137995
		[Token(Token = "0x4021B0B")]
		[FieldOffset(Offset = "0x18")]
		public string desc;

		// Token: 0x04021B0C RID: 137996
		[Token(Token = "0x4021B0C")]
		[FieldOffset(Offset = "0x20")]
		public string iconId;

		// Token: 0x04021B0D RID: 137997
		[Token(Token = "0x4021B0D")]
		[FieldOffset(Offset = "0x28")]
		public string smallIconId;

		// Token: 0x04021B0E RID: 137998
		[Token(Token = "0x4021B0E")]
		[FieldOffset(Offset = "0x30")]
		public string topicId;

		// Token: 0x04021B0F RID: 137999
		[Token(Token = "0x4021B0F")]
		[FieldOffset(Offset = "0x38")]
		private int m_sortId;

		// Token: 0x04021B10 RID: 138000
		[Token(Token = "0x4021B10")]
		[FieldOffset(Offset = "0x40")]
		private string m_medalId;

		// Token: 0x04021B11 RID: 138001
		[Token(Token = "0x4021B11")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x04021B12 RID: 138002
		[Token(Token = "0x4021B12")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_CompareTo;
	}
}
