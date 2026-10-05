using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004300 RID: 17152
	[Token(Token = "0x2004300")]
	public class SandboxV2EventViewModel : IHotfixable
	{
		// Token: 0x17003E7D RID: 15997
		// (get) Token: 0x0601A5A1 RID: 107937 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003E7D")]
		public string topicId
		{
			[Token(Token = "0x601A5A1")]
			[Address(RVA = "0x134A880", Offset = "0x1349480", VA = "0x18134A880")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003E7E RID: 15998
		// (get) Token: 0x0601A5A2 RID: 107938 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003E7E")]
		public string nodeId
		{
			[Token(Token = "0x601A5A2")]
			[Address(RVA = "0x134A760", Offset = "0x1349360", VA = "0x18134A760")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003E7F RID: 15999
		// (get) Token: 0x0601A5A3 RID: 107939 RVA: 0x000A1880 File Offset: 0x0009FA80
		[Token(Token = "0x17003E7F")]
		public int instId
		{
			[Token(Token = "0x601A5A3")]
			[Address(RVA = "0x134A700", Offset = "0x1349300", VA = "0x18134A700")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17003E80 RID: 16000
		// (get) Token: 0x0601A5A4 RID: 107940 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003E80")]
		public string eventId
		{
			[Token(Token = "0x601A5A4")]
			[Address(RVA = "0x134A5E0", Offset = "0x13491E0", VA = "0x18134A5E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003E81 RID: 16001
		// (get) Token: 0x0601A5A5 RID: 107941 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003E81")]
		public string eventSceneId
		{
			[Token(Token = "0x601A5A5")]
			[Address(RVA = "0x134A640", Offset = "0x1349240", VA = "0x18134A640")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003E82 RID: 16002
		// (get) Token: 0x0601A5A6 RID: 107942 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003E82")]
		public ListDict<string, SandboxV2EventChoiceViewModel> choices
		{
			[Token(Token = "0x601A5A6")]
			[Address(RVA = "0x134A4C0", Offset = "0x13490C0", VA = "0x18134A4C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003E83 RID: 16003
		// (get) Token: 0x0601A5A7 RID: 107943 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003E83")]
		public string title
		{
			[Token(Token = "0x601A5A7")]
			[Address(RVA = "0x134A820", Offset = "0x1349420", VA = "0x18134A820")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003E84 RID: 16004
		// (get) Token: 0x0601A5A8 RID: 107944 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003E84")]
		public string desc
		{
			[Token(Token = "0x601A5A8")]
			[Address(RVA = "0x134A520", Offset = "0x1349120", VA = "0x18134A520")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003E85 RID: 16005
		// (get) Token: 0x0601A5A9 RID: 107945 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003E85")]
		public string iconId
		{
			[Token(Token = "0x601A5A9")]
			[Address(RVA = "0x134A6A0", Offset = "0x13492A0", VA = "0x18134A6A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003E86 RID: 16006
		// (get) Token: 0x0601A5AA RID: 107946 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003E86")]
		public string nodeTypeIconId
		{
			[Token(Token = "0x601A5AA")]
			[Address(RVA = "0x134A7C0", Offset = "0x13493C0", VA = "0x18134A7C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003E87 RID: 16007
		// (get) Token: 0x0601A5AB RID: 107947 RVA: 0x000A1898 File Offset: 0x0009FA98
		[Token(Token = "0x17003E87")]
		public SandboxV2EventType type
		{
			[Token(Token = "0x601A5AB")]
			[Address(RVA = "0x134A8E0", Offset = "0x13494E0", VA = "0x18134A8E0")]
			get
			{
				return SandboxV2EventType.NONE;
			}
		}

		// Token: 0x17003E88 RID: 16008
		// (get) Token: 0x0601A5AC RID: 107948 RVA: 0x000A18B0 File Offset: 0x0009FAB0
		[Token(Token = "0x17003E88")]
		public int animSeq
		{
			[Token(Token = "0x601A5AC")]
			[Address(RVA = "0x134A460", Offset = "0x1349060", VA = "0x18134A460")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17003E89 RID: 16009
		// (get) Token: 0x0601A5AD RID: 107949 RVA: 0x000A18C8 File Offset: 0x0009FAC8
		[Token(Token = "0x17003E89")]
		public int enterSeq
		{
			[Token(Token = "0x601A5AD")]
			[Address(RVA = "0x134A580", Offset = "0x1349180", VA = "0x18134A580")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0601A5AE RID: 107950 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A5AE")]
		[Address(RVA = "0x1349CD0", Offset = "0x13488D0", VA = "0x181349CD0")]
		public void InitData(string topicId, SandboxV2DungeonNodeViewModel nodeViewModel)
		{
		}

		// Token: 0x0601A5AF RID: 107951 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A5AF")]
		[Address(RVA = "0x1349E30", Offset = "0x1348A30", VA = "0x181349E30")]
		public void LoadData(string topicId, SandboxV2DungeonNodeViewModel nodeViewModel, int currAp)
		{
		}

		// Token: 0x0601A5B0 RID: 107952 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A5B0")]
		[Address(RVA = "0x1349C00", Offset = "0x1348800", VA = "0x181349C00")]
		public SandboxV2EventChoiceViewModel GetSelectedChoiceViewModel()
		{
			return null;
		}

		// Token: 0x0601A5B1 RID: 107953 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A5B1")]
		[Address(RVA = "0x134A2E0", Offset = "0x1348EE0", VA = "0x18134A2E0")]
		public void NotifyAnimSeq()
		{
		}

		// Token: 0x0601A5B2 RID: 107954 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A5B2")]
		[Address(RVA = "0x134A340", Offset = "0x1348F40", VA = "0x18134A340")]
		public void NotifyEnterSeq()
		{
		}

		// Token: 0x0601A5B3 RID: 107955 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A5B3")]
		[Address(RVA = "0x134A3A0", Offset = "0x1348FA0", VA = "0x18134A3A0")]
		public SandboxV2EventViewModel()
		{
		}

		// Token: 0x0402173E RID: 137022
		[Token(Token = "0x402173E")]
		[FieldOffset(Offset = "0x10")]
		private string m_topicId;

		// Token: 0x0402173F RID: 137023
		[Token(Token = "0x402173F")]
		[FieldOffset(Offset = "0x18")]
		private string m_nodeId;

		// Token: 0x04021740 RID: 137024
		[Token(Token = "0x4021740")]
		[FieldOffset(Offset = "0x20")]
		private int m_instId;

		// Token: 0x04021741 RID: 137025
		[Token(Token = "0x4021741")]
		[FieldOffset(Offset = "0x28")]
		private string m_eventId;

		// Token: 0x04021742 RID: 137026
		[Token(Token = "0x4021742")]
		[FieldOffset(Offset = "0x30")]
		private string m_eventSceneId;

		// Token: 0x04021743 RID: 137027
		[Token(Token = "0x4021743")]
		[FieldOffset(Offset = "0x38")]
		private string m_title;

		// Token: 0x04021744 RID: 137028
		[Token(Token = "0x4021744")]
		[FieldOffset(Offset = "0x40")]
		private string m_desc;

		// Token: 0x04021745 RID: 137029
		[Token(Token = "0x4021745")]
		[FieldOffset(Offset = "0x48")]
		private string m_iconId;

		// Token: 0x04021746 RID: 137030
		[Token(Token = "0x4021746")]
		[FieldOffset(Offset = "0x50")]
		private string m_nodeTypeIconId;

		// Token: 0x04021747 RID: 137031
		[Token(Token = "0x4021747")]
		[FieldOffset(Offset = "0x58")]
		private SandboxV2EventType m_type;

		// Token: 0x04021748 RID: 137032
		[Token(Token = "0x4021748")]
		[FieldOffset(Offset = "0x60")]
		private ListDict<string, SandboxV2EventChoiceViewModel> m_choices;

		// Token: 0x04021749 RID: 137033
		[Token(Token = "0x4021749")]
		[FieldOffset(Offset = "0x68")]
		private int m_animSequence;

		// Token: 0x0402174A RID: 137034
		[Token(Token = "0x402174A")]
		[FieldOffset(Offset = "0x6C")]
		private int m_enterSequence;

		// Token: 0x0402174B RID: 137035
		[Token(Token = "0x402174B")]
		[FieldOffset(Offset = "0x70")]
		public string selectedChoiceId;

		// Token: 0x0402174C RID: 137036
		[Token(Token = "0x402174C")]
		[FieldOffset(Offset = "0x78")]
		public string confirmedChoiceId;

		// Token: 0x0402174D RID: 137037
		[Token(Token = "0x402174D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_topicId;

		// Token: 0x0402174E RID: 137038
		[Token(Token = "0x402174E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_nodeId;

		// Token: 0x0402174F RID: 137039
		[Token(Token = "0x402174F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_instId;

		// Token: 0x04021750 RID: 137040
		[Token(Token = "0x4021750")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_eventId;

		// Token: 0x04021751 RID: 137041
		[Token(Token = "0x4021751")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_eventSceneId;

		// Token: 0x04021752 RID: 137042
		[Token(Token = "0x4021752")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_choices;

		// Token: 0x04021753 RID: 137043
		[Token(Token = "0x4021753")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_title;

		// Token: 0x04021754 RID: 137044
		[Token(Token = "0x4021754")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_desc;

		// Token: 0x04021755 RID: 137045
		[Token(Token = "0x4021755")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_iconId;

		// Token: 0x04021756 RID: 137046
		[Token(Token = "0x4021756")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_nodeTypeIconId;

		// Token: 0x04021757 RID: 137047
		[Token(Token = "0x4021757")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_type;

		// Token: 0x04021758 RID: 137048
		[Token(Token = "0x4021758")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_get_animSeq;

		// Token: 0x04021759 RID: 137049
		[Token(Token = "0x4021759")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_get_enterSeq;

		// Token: 0x0402175A RID: 137050
		[Token(Token = "0x402175A")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_InitData;

		// Token: 0x0402175B RID: 137051
		[Token(Token = "0x402175B")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402175C RID: 137052
		[Token(Token = "0x402175C")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_GetSelectedChoiceViewModel;

		// Token: 0x0402175D RID: 137053
		[Token(Token = "0x402175D")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_NotifyAnimSeq;

		// Token: 0x0402175E RID: 137054
		[Token(Token = "0x402175E")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_NotifyEnterSeq;

		// Token: 0x0402175F RID: 137055
		[Token(Token = "0x402175F")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
