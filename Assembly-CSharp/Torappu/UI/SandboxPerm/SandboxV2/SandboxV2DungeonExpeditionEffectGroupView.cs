using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020041FF RID: 16895
	[Token(Token = "0x20041FF")]
	public class SandboxV2DungeonExpeditionEffectGroupView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601A12F RID: 106799 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A12F")]
		[Address(RVA = "0x12EAA10", Offset = "0x12E9610", VA = "0x1812EAA10")]
		public void Render(SandboxV2DungeonMiscExpeditionItemViewModel groupViewModel, bool showLine)
		{
		}

		// Token: 0x0601A130 RID: 106800 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A130")]
		[Address(RVA = "0x12EACB0", Offset = "0x12E98B0", VA = "0x1812EACB0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601A131 RID: 106801 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A131")]
		[Address(RVA = "0x12EADD0", Offset = "0x12E99D0", VA = "0x1812EADD0")]
		public SandboxV2DungeonExpeditionEffectGroupView()
		{
		}

		// Token: 0x04020D90 RID: 134544
		[Token(Token = "0x4020D90")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SimpleLayoutContent _content;

		// Token: 0x04020D91 RID: 134545
		[Token(Token = "0x4020D91")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _statusDesc;

		// Token: 0x04020D92 RID: 134546
		[Token(Token = "0x4020D92")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _effectDesc;

		// Token: 0x04020D93 RID: 134547
		[Token(Token = "0x4020D93")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _panelLine;

		// Token: 0x04020D94 RID: 134548
		[Token(Token = "0x4020D94")]
		[FieldOffset(Offset = "0x38")]
		private bool m_isInited;

		// Token: 0x04020D95 RID: 134549
		[Token(Token = "0x4020D95")]
		[FieldOffset(Offset = "0x40")]
		private SandboxV2DungeonExpeditionEffectGroupView.Adapter m_adapter;

		// Token: 0x04020D96 RID: 134550
		[Token(Token = "0x4020D96")]
		[FieldOffset(Offset = "0x48")]
		private SandboxV2DungeonMiscExpeditionItemViewModel m_cachedViewModel;

		// Token: 0x04020D97 RID: 134551
		[Token(Token = "0x4020D97")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04020D98 RID: 134552
		[Token(Token = "0x4020D98")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04020D99 RID: 134553
		[Token(Token = "0x4020D99")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004200 RID: 16896
		[Token(Token = "0x2004200")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x0601A132 RID: 106802 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601A132")]
			[Address(RVA = "0x12E6680", Offset = "0x12E5280", VA = "0x1812E6680")]
			public Adapter(SandboxV2DungeonExpeditionEffectGroupView closure)
			{
			}

			// Token: 0x17003E12 RID: 15890
			// (get) Token: 0x0601A133 RID: 106803 RVA: 0x000A0398 File Offset: 0x0009E598
			[Token(Token = "0x17003E12")]
			public override int count
			{
				[Token(Token = "0x601A133")]
				[Address(RVA = "0x12E6A40", Offset = "0x12E5640", VA = "0x1812E6A40", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601A134 RID: 106804 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601A134")]
			[Address(RVA = "0x12E5ED0", Offset = "0x12E4AD0", VA = "0x1812E5ED0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x04020D9A RID: 134554
			[Token(Token = "0x4020D9A")]
			[FieldOffset(Offset = "0x20")]
			private SandboxV2DungeonExpeditionEffectGroupView m_closure;

			// Token: 0x04020D9B RID: 134555
			[Token(Token = "0x4020D9B")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04020D9C RID: 134556
			[Token(Token = "0x4020D9C")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04020D9D RID: 134557
			[Token(Token = "0x4020D9D")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
