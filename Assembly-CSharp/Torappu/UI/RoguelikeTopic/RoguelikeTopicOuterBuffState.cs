using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.RoguelikeTopic
{
	// Token: 0x0200452C RID: 17708
	[Token(Token = "0x200452C")]
	public class RoguelikeTopicOuterBuffState : PopupFadeState
	{
		// Token: 0x0601B017 RID: 110615 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601B017")]
		[Address(RVA = "0x142C890", Offset = "0x142B490", VA = "0x18142C890", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0601B018 RID: 110616 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B018")]
		[Address(RVA = "0x142C8F0", Offset = "0x142B4F0", VA = "0x18142C8F0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0601B019 RID: 110617 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B019")]
		[Address(RVA = "0x142CE50", Offset = "0x142BA50", VA = "0x18142CE50", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x0601B01A RID: 110618 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B01A")]
		[Address(RVA = "0x142CD70", Offset = "0x142B970", VA = "0x18142CD70", Slot = "18")]
		protected override void OnExit()
		{
		}

		// Token: 0x0601B01B RID: 110619 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B01B")]
		[Address(RVA = "0x142CF40", Offset = "0x142BB40", VA = "0x18142CF40")]
		private void _DestroyOuterBuffView()
		{
		}

		// Token: 0x0601B01C RID: 110620 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B01C")]
		[Address(RVA = "0x142D020", Offset = "0x142BC20", VA = "0x18142D020")]
		public RoguelikeTopicOuterBuffState()
		{
		}

		// Token: 0x0601B01D RID: 110621 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B01D")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0601B01E RID: 110622 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B01E")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x0601B01F RID: 110623 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B01F")]
		[Address(RVA = "0xE63460", Offset = "0xE62060", VA = "0x180E63460")]
		private void <>xLuaBaseProxy_OnExit()
		{
		}

		// Token: 0x04022AFF RID: 142079
		[Token(Token = "0x4022AFF")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private RectTransform _outerBuffViewHolder;

		// Token: 0x04022B00 RID: 142080
		[Token(Token = "0x4022B00")]
		[FieldOffset(Offset = "0x78")]
		private string m_topicId;

		// Token: 0x04022B01 RID: 142081
		[Token(Token = "0x4022B01")]
		[FieldOffset(Offset = "0x80")]
		private RoguelikeTopicOuterBuffController m_outerBuffController;

		// Token: 0x04022B02 RID: 142082
		[Token(Token = "0x4022B02")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04022B03 RID: 142083
		[Token(Token = "0x4022B03")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04022B04 RID: 142084
		[Token(Token = "0x4022B04")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x04022B05 RID: 142085
		[Token(Token = "0x4022B05")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnExit;

		// Token: 0x04022B06 RID: 142086
		[Token(Token = "0x4022B06")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__DestroyOuterBuffView;

		// Token: 0x04022B07 RID: 142087
		[Token(Token = "0x4022B07")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
