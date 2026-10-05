using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Tuning
{
	// Token: 0x02003CED RID: 15597
	[Token(Token = "0x2003CED")]
	public class TuningProductStateBean : IStateBean, IHotfixable
	{
		// Token: 0x17003A15 RID: 14869
		// (get) Token: 0x06018535 RID: 99637 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003A15")]
		public TuningProductProperty prop
		{
			[Token(Token = "0x6018535")]
			[Address(RVA = "0x10E36D0", Offset = "0x10E22D0", VA = "0x1810E36D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003A16 RID: 14870
		// (get) Token: 0x06018536 RID: 99638 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003A16")]
		public string resultProductId
		{
			[Token(Token = "0x6018536")]
			[Address(RVA = "0x10E3730", Offset = "0x10E2330", VA = "0x1810E3730")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003A17 RID: 14871
		// (get) Token: 0x06018537 RID: 99639 RVA: 0x0009A038 File Offset: 0x00098238
		[Token(Token = "0x17003A17")]
		public bool isMusicFromStart
		{
			[Token(Token = "0x6018537")]
			[Address(RVA = "0x10E3670", Offset = "0x10E2270", VA = "0x1810E3670")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17003A18 RID: 14872
		// (get) Token: 0x06018538 RID: 99640 RVA: 0x0009A050 File Offset: 0x00098250
		[Token(Token = "0x17003A18")]
		public bool resultProductIsNew
		{
			[Token(Token = "0x6018538")]
			[Address(RVA = "0x10E3790", Offset = "0x10E2390", VA = "0x1810E3790")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06018539 RID: 99641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018539")]
		[Address(RVA = "0x10E2C90", Offset = "0x10E1890", VA = "0x1810E2C90")]
		public void InitData(string actId)
		{
		}

		// Token: 0x0601853A RID: 99642 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601853A")]
		[Address(RVA = "0x10E3180", Offset = "0x10E1D80", VA = "0x1810E3180")]
		public void UpdateData()
		{
		}

		// Token: 0x0601853B RID: 99643 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601853B")]
		[Address(RVA = "0x10E3100", Offset = "0x10E1D00", VA = "0x1810E3100")]
		public void SetResultProductId(string inputProductId)
		{
		}

		// Token: 0x0601853C RID: 99644 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601853C")]
		[Address(RVA = "0x10E3090", Offset = "0x10E1C90", VA = "0x1810E3090")]
		public void SetMusicPlayType(bool iIsMusicFromStart)
		{
		}

		// Token: 0x0601853D RID: 99645 RVA: 0x0009A068 File Offset: 0x00098268
		[Token(Token = "0x601853D")]
		[Address(RVA = "0x10E2BA0", Offset = "0x10E17A0", VA = "0x1810E2BA0")]
		public bool CheckResProductIsNewProductType(Dictionary<string, int> prevFormNax, string productId, out string productTypeId)
		{
			return default(bool);
		}

		// Token: 0x0601853E RID: 99646 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601853E")]
		[Address(RVA = "0x10E3510", Offset = "0x10E2110", VA = "0x1810E3510")]
		private void _SetResultProductIsNew(bool iResultIsNew)
		{
		}

		// Token: 0x0601853F RID: 99647 RVA: 0x0009A080 File Offset: 0x00098280
		[Token(Token = "0x601853F")]
		[Address(RVA = "0x10E3210", Offset = "0x10E1E10", VA = "0x1810E3210")]
		private bool _CheckResProductIsNewProductType(Dictionary<string, int> prevFormNax, string productId, out string productTypeId)
		{
			return default(bool);
		}

		// Token: 0x06018540 RID: 99648 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018540")]
		[Address(RVA = "0x10E3580", Offset = "0x10E2180", VA = "0x1810E3580")]
		public TuningProductStateBean()
		{
		}

		// Token: 0x0401DB84 RID: 121732
		[Token(Token = "0x401DB84")]
		[FieldOffset(Offset = "0x10")]
		private TuningProductProperty m_prop;

		// Token: 0x0401DB85 RID: 121733
		[Token(Token = "0x401DB85")]
		[FieldOffset(Offset = "0x18")]
		private string m_actId;

		// Token: 0x0401DB86 RID: 121734
		[Token(Token = "0x401DB86")]
		[FieldOffset(Offset = "0x20")]
		private int m_enterSequenceNum;

		// Token: 0x0401DB87 RID: 121735
		[Token(Token = "0x401DB87")]
		[FieldOffset(Offset = "0x28")]
		private string m_resultProductId;

		// Token: 0x0401DB88 RID: 121736
		[Token(Token = "0x401DB88")]
		[FieldOffset(Offset = "0x30")]
		private bool m_isMusicFromStart;

		// Token: 0x0401DB89 RID: 121737
		[Token(Token = "0x401DB89")]
		[FieldOffset(Offset = "0x31")]
		private bool m_resultProductIsNew;

		// Token: 0x0401DB8A RID: 121738
		[Token(Token = "0x401DB8A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_prop;

		// Token: 0x0401DB8B RID: 121739
		[Token(Token = "0x401DB8B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_resultProductId;

		// Token: 0x0401DB8C RID: 121740
		[Token(Token = "0x401DB8C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_isMusicFromStart;

		// Token: 0x0401DB8D RID: 121741
		[Token(Token = "0x401DB8D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_resultProductIsNew;

		// Token: 0x0401DB8E RID: 121742
		[Token(Token = "0x401DB8E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_InitData;

		// Token: 0x0401DB8F RID: 121743
		[Token(Token = "0x401DB8F")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_UpdateData;

		// Token: 0x0401DB90 RID: 121744
		[Token(Token = "0x401DB90")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_SetResultProductId;

		// Token: 0x0401DB91 RID: 121745
		[Token(Token = "0x401DB91")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_SetMusicPlayType;

		// Token: 0x0401DB92 RID: 121746
		[Token(Token = "0x401DB92")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_CheckResProductIsNewProductType;

		// Token: 0x0401DB93 RID: 121747
		[Token(Token = "0x401DB93")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__SetResultProductIsNew;

		// Token: 0x0401DB94 RID: 121748
		[Token(Token = "0x401DB94")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__CheckResProductIsNewProductType;

		// Token: 0x0401DB95 RID: 121749
		[Token(Token = "0x401DB95")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
