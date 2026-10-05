using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.RoguelikeTopic.RL01
{
	// Token: 0x02004668 RID: 18024
	[Token(Token = "0x2004668")]
	public class Rl01TopicOuterBuffController : RoguelikeTopicOuterBuffController
	{
		// Token: 0x0601B5DE RID: 112094 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B5DE")]
		[Address(RVA = "0x14AE490", Offset = "0x14AD090", VA = "0x1814AE490", Slot = "4")]
		public override void Init()
		{
		}

		// Token: 0x0601B5DF RID: 112095 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B5DF")]
		[Address(RVA = "0x14AE7E0", Offset = "0x14AD3E0", VA = "0x1814AE7E0", Slot = "5")]
		public override void OnEnter(string topicId)
		{
		}

		// Token: 0x0601B5E0 RID: 112096 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B5E0")]
		[Address(RVA = "0x14AEBC0", Offset = "0x14AD7C0", VA = "0x1814AEBC0", Slot = "6")]
		public override void OnResume(bool isResumeFromStack)
		{
		}

		// Token: 0x0601B5E1 RID: 112097 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B5E1")]
		[Address(RVA = "0x14AECD0", Offset = "0x14AD8D0", VA = "0x1814AECD0")]
		public void SetNodeSelected(string nodeId)
		{
		}

		// Token: 0x0601B5E2 RID: 112098 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B5E2")]
		[Address(RVA = "0x14AEFB0", Offset = "0x14ADBB0", VA = "0x1814AEFB0")]
		public void UpgradeNode(string nodeId)
		{
		}

		// Token: 0x0601B5E3 RID: 112099 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B5E3")]
		[Address(RVA = "0x14AF1F0", Offset = "0x14ADDF0", VA = "0x1814AF1F0")]
		public Rl01TopicOuterBuffController()
		{
		}

		// Token: 0x0601B5E5 RID: 112101 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B5E5")]
		[Address(RVA = "0x1456430", Offset = "0x1455030", VA = "0x181456430")]
		private void <>xLuaBaseProxy_Init()
		{
		}

		// Token: 0x0601B5E6 RID: 112102 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B5E6")]
		[Address(RVA = "0x1456440", Offset = "0x1455040", VA = "0x181456440")]
		private void <>xLuaBaseProxy_OnEnter(string P0)
		{
		}

		// Token: 0x0601B5E7 RID: 112103 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B5E7")]
		[Address(RVA = "0x1456450", Offset = "0x1455050", VA = "0x181456450")]
		private void <>xLuaBaseProxy_OnResume(bool P0)
		{
		}

		// Token: 0x040235DD RID: 144861
		[Token(Token = "0x40235DD")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Rl01OuterBuffTokenView _tokenView;

		// Token: 0x040235DE RID: 144862
		[Token(Token = "0x40235DE")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Rl01OuterBuffView _outerBuffView;

		// Token: 0x040235DF RID: 144863
		[Token(Token = "0x40235DF")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private RectTransform _topMenuContainer;

		// Token: 0x040235E0 RID: 144864
		[Token(Token = "0x40235E0")]
		[FieldOffset(Offset = "0x40")]
		private Rl01TopicOuterBuffViewModel m_viewModel;

		// Token: 0x040235E1 RID: 144865
		[Token(Token = "0x40235E1")]
		[FieldOffset(Offset = "0x48")]
		private string m_topicId;

		// Token: 0x040235E2 RID: 144866
		[Token(Token = "0x40235E2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x040235E3 RID: 144867
		[Token(Token = "0x40235E3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x040235E4 RID: 144868
		[Token(Token = "0x40235E4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x040235E5 RID: 144869
		[Token(Token = "0x40235E5")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_SetNodeSelected;

		// Token: 0x040235E6 RID: 144870
		[Token(Token = "0x40235E6")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_UpgradeNode;

		// Token: 0x040235E7 RID: 144871
		[Token(Token = "0x40235E7")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
