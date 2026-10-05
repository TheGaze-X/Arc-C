using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Recruit
{
	// Token: 0x020046FF RID: 18175
	[Token(Token = "0x20046FF")]
	public class BuildTopBarViewModel : IHotfixable
	{
		// Token: 0x17004197 RID: 16791
		// (get) Token: 0x0601B8F8 RID: 112888 RVA: 0x000A57E0 File Offset: 0x000A39E0
		// (set) Token: 0x0601B8F9 RID: 112889 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004197")]
		public bool hasRecruitOnlyAct
		{
			[Token(Token = "0x601B8F8")]
			[Address(RVA = "0x14DB3E0", Offset = "0x14D9FE0", VA = "0x1814DB3E0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x601B8F9")]
			[Address(RVA = "0x14DB5E0", Offset = "0x14DA1E0", VA = "0x1814DB5E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17004198 RID: 16792
		// (get) Token: 0x0601B8FA RID: 112890 RVA: 0x000A57F8 File Offset: 0x000A39F8
		// (set) Token: 0x0601B8FB RID: 112891 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004198")]
		public bool hasUsed
		{
			[Token(Token = "0x601B8FA")]
			[Address(RVA = "0x14DB440", Offset = "0x14DA040", VA = "0x1814DB440")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x601B8FB")]
			[Address(RVA = "0x14DB650", Offset = "0x14DA250", VA = "0x1814DB650")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17004199 RID: 16793
		// (get) Token: 0x0601B8FC RID: 112892 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601B8FD RID: 112893 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004199")]
		public string tagName
		{
			[Token(Token = "0x601B8FC")]
			[Address(RVA = "0x14DB500", Offset = "0x14DA100", VA = "0x1814DB500")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601B8FD")]
			[Address(RVA = "0x14DB740", Offset = "0x14DA340", VA = "0x1814DB740")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700419A RID: 16794
		// (get) Token: 0x0601B8FE RID: 112894 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601B8FF RID: 112895 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700419A")]
		public string remainTime
		{
			[Token(Token = "0x601B8FE")]
			[Address(RVA = "0x14DB4A0", Offset = "0x14DA0A0", VA = "0x1814DB4A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601B8FF")]
			[Address(RVA = "0x14DB6C0", Offset = "0x14DA2C0", VA = "0x1814DB6C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700419B RID: 16795
		// (get) Token: 0x0601B900 RID: 112896 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601B901 RID: 112897 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700419B")]
		public string desc
		{
			[Token(Token = "0x601B900")]
			[Address(RVA = "0x14DB380", Offset = "0x14D9F80", VA = "0x1814DB380")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601B901")]
			[Address(RVA = "0x14DB560", Offset = "0x14DA160", VA = "0x1814DB560")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0601B902 RID: 112898 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B902")]
		[Address(RVA = "0x14DAB80", Offset = "0x14D9780", VA = "0x1814DAB80")]
		public void LoadData()
		{
		}

		// Token: 0x0601B903 RID: 112899 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B903")]
		[Address(RVA = "0x14DB040", Offset = "0x14D9C40", VA = "0x1814DB040")]
		public void UpdateData()
		{
		}

		// Token: 0x0601B904 RID: 112900 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601B904")]
		[Address(RVA = "0x14DB1E0", Offset = "0x14D9DE0", VA = "0x1814DB1E0")]
		private string _GetRemainTimeStr(long endTime)
		{
			return null;
		}

		// Token: 0x0601B905 RID: 112901 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B905")]
		[Address(RVA = "0x14DB320", Offset = "0x14D9F20", VA = "0x1814DB320")]
		public BuildTopBarViewModel()
		{
		}

		// Token: 0x04023B2B RID: 146219
		[Token(Token = "0x4023B2B")]
		[FieldOffset(Offset = "0x30")]
		private string m_actId;

		// Token: 0x04023B2C RID: 146220
		[Token(Token = "0x4023B2C")]
		[FieldOffset(Offset = "0x38")]
		private int m_tagTimes;

		// Token: 0x04023B2D RID: 146221
		[Token(Token = "0x4023B2D")]
		[FieldOffset(Offset = "0x40")]
		private long m_endTime;

		// Token: 0x04023B2E RID: 146222
		[Token(Token = "0x4023B2E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_hasRecruitOnlyAct;

		// Token: 0x04023B2F RID: 146223
		[Token(Token = "0x4023B2F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_hasRecruitOnlyAct;

		// Token: 0x04023B30 RID: 146224
		[Token(Token = "0x4023B30")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_hasUsed;

		// Token: 0x04023B31 RID: 146225
		[Token(Token = "0x4023B31")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_hasUsed;

		// Token: 0x04023B32 RID: 146226
		[Token(Token = "0x4023B32")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_tagName;

		// Token: 0x04023B33 RID: 146227
		[Token(Token = "0x4023B33")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_tagName;

		// Token: 0x04023B34 RID: 146228
		[Token(Token = "0x4023B34")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_remainTime;

		// Token: 0x04023B35 RID: 146229
		[Token(Token = "0x4023B35")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_remainTime;

		// Token: 0x04023B36 RID: 146230
		[Token(Token = "0x4023B36")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_desc;

		// Token: 0x04023B37 RID: 146231
		[Token(Token = "0x4023B37")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_set_desc;

		// Token: 0x04023B38 RID: 146232
		[Token(Token = "0x4023B38")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04023B39 RID: 146233
		[Token(Token = "0x4023B39")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_UpdateData;

		// Token: 0x04023B3A RID: 146234
		[Token(Token = "0x4023B3A")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__GetRemainTimeStr;

		// Token: 0x04023B3B RID: 146235
		[Token(Token = "0x4023B3B")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
