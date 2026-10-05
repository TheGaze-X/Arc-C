using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020042FF RID: 17151
	[Token(Token = "0x20042FF")]
	public class SandboxV2EventChoiceViewModel : IHotfixable
	{
		// Token: 0x17003E73 RID: 15987
		// (get) Token: 0x0601A595 RID: 107925 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003E73")]
		public string choiceId
		{
			[Token(Token = "0x601A595")]
			[Address(RVA = "0x13497E0", Offset = "0x13483E0", VA = "0x1813497E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003E74 RID: 15988
		// (get) Token: 0x0601A596 RID: 107926 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003E74")]
		public string title
		{
			[Token(Token = "0x601A596")]
			[Address(RVA = "0x1349AE0", Offset = "0x13486E0", VA = "0x181349AE0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003E75 RID: 15989
		// (get) Token: 0x0601A597 RID: 107927 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003E75")]
		public string desc
		{
			[Token(Token = "0x601A597")]
			[Address(RVA = "0x13498A0", Offset = "0x13484A0", VA = "0x1813498A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003E76 RID: 15990
		// (get) Token: 0x0601A598 RID: 107928 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003E76")]
		public string expeditionId
		{
			[Token(Token = "0x601A598")]
			[Address(RVA = "0x1349A20", Offset = "0x1348620", VA = "0x181349A20")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003E77 RID: 15991
		// (get) Token: 0x0601A599 RID: 107929 RVA: 0x000A17F0 File Offset: 0x0009F9F0
		[Token(Token = "0x17003E77")]
		public int expeditionDuration
		{
			[Token(Token = "0x601A599")]
			[Address(RVA = "0x13499C0", Offset = "0x13485C0", VA = "0x1813499C0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17003E78 RID: 15992
		// (get) Token: 0x0601A59A RID: 107930 RVA: 0x000A1808 File Offset: 0x0009FA08
		[Token(Token = "0x17003E78")]
		public int expeditionCharCount
		{
			[Token(Token = "0x601A59A")]
			[Address(RVA = "0x1349960", Offset = "0x1348560", VA = "0x181349960")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17003E79 RID: 15993
		// (get) Token: 0x0601A59B RID: 107931 RVA: 0x000A1820 File Offset: 0x0009FA20
		[Token(Token = "0x17003E79")]
		public SandboxV2EventChoiceType type
		{
			[Token(Token = "0x601A59B")]
			[Address(RVA = "0x1349B40", Offset = "0x1348740", VA = "0x181349B40")]
			get
			{
				return SandboxV2EventChoiceType.NONE;
			}
		}

		// Token: 0x17003E7A RID: 15994
		// (get) Token: 0x0601A59C RID: 107932 RVA: 0x000A1838 File Offset: 0x0009FA38
		[Token(Token = "0x17003E7A")]
		public int costAction
		{
			[Token(Token = "0x601A59C")]
			[Address(RVA = "0x1349840", Offset = "0x1348440", VA = "0x181349840")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17003E7B RID: 15995
		// (get) Token: 0x0601A59D RID: 107933 RVA: 0x000A1850 File Offset: 0x0009FA50
		[Token(Token = "0x17003E7B")]
		public bool enoughAction
		{
			[Token(Token = "0x601A59D")]
			[Address(RVA = "0x1349900", Offset = "0x1348500", VA = "0x181349900")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17003E7C RID: 15996
		// (get) Token: 0x0601A59E RID: 107934 RVA: 0x000A1868 File Offset: 0x0009FA68
		[Token(Token = "0x17003E7C")]
		public bool needAction
		{
			[Token(Token = "0x601A59E")]
			[Address(RVA = "0x1349A80", Offset = "0x1348680", VA = "0x181349A80")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0601A59F RID: 107935 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A59F")]
		[Address(RVA = "0x1349620", Offset = "0x1348220", VA = "0x181349620")]
		public void LoadData(SandboxV2Data sandboxData, SandboxV2EventChoiceData choiceData, int playerAp)
		{
		}

		// Token: 0x0601A5A0 RID: 107936 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A5A0")]
		[Address(RVA = "0x1349780", Offset = "0x1348380", VA = "0x181349780")]
		public SandboxV2EventChoiceViewModel()
		{
		}

		// Token: 0x04021728 RID: 137000
		[Token(Token = "0x4021728")]
		[FieldOffset(Offset = "0x10")]
		private string m_choiceId;

		// Token: 0x04021729 RID: 137001
		[Token(Token = "0x4021729")]
		[FieldOffset(Offset = "0x18")]
		private string m_title;

		// Token: 0x0402172A RID: 137002
		[Token(Token = "0x402172A")]
		[FieldOffset(Offset = "0x20")]
		private string m_desc;

		// Token: 0x0402172B RID: 137003
		[Token(Token = "0x402172B")]
		[FieldOffset(Offset = "0x28")]
		private string m_expeditionId;

		// Token: 0x0402172C RID: 137004
		[Token(Token = "0x402172C")]
		[FieldOffset(Offset = "0x30")]
		private int m_expeditionDuration;

		// Token: 0x0402172D RID: 137005
		[Token(Token = "0x402172D")]
		[FieldOffset(Offset = "0x34")]
		private int m_expeditionCharCount;

		// Token: 0x0402172E RID: 137006
		[Token(Token = "0x402172E")]
		[FieldOffset(Offset = "0x38")]
		private SandboxV2EventChoiceType m_type;

		// Token: 0x0402172F RID: 137007
		[Token(Token = "0x402172F")]
		[FieldOffset(Offset = "0x3C")]
		private int m_costAction;

		// Token: 0x04021730 RID: 137008
		[Token(Token = "0x4021730")]
		[FieldOffset(Offset = "0x40")]
		private bool m_enoughAction;

		// Token: 0x04021731 RID: 137009
		[Token(Token = "0x4021731")]
		[FieldOffset(Offset = "0x41")]
		private bool m_needAction;

		// Token: 0x04021732 RID: 137010
		[Token(Token = "0x4021732")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_choiceId;

		// Token: 0x04021733 RID: 137011
		[Token(Token = "0x4021733")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_title;

		// Token: 0x04021734 RID: 137012
		[Token(Token = "0x4021734")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_desc;

		// Token: 0x04021735 RID: 137013
		[Token(Token = "0x4021735")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_expeditionId;

		// Token: 0x04021736 RID: 137014
		[Token(Token = "0x4021736")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_expeditionDuration;

		// Token: 0x04021737 RID: 137015
		[Token(Token = "0x4021737")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_expeditionCharCount;

		// Token: 0x04021738 RID: 137016
		[Token(Token = "0x4021738")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_type;

		// Token: 0x04021739 RID: 137017
		[Token(Token = "0x4021739")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_costAction;

		// Token: 0x0402173A RID: 137018
		[Token(Token = "0x402173A")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_enoughAction;

		// Token: 0x0402173B RID: 137019
		[Token(Token = "0x402173B")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_needAction;

		// Token: 0x0402173C RID: 137020
		[Token(Token = "0x402173C")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402173D RID: 137021
		[Token(Token = "0x402173D")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
