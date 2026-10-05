using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004202 RID: 16898
	[Token(Token = "0x2004202")]
	public class SandboxV2DungeonExpeditionEffectView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601A137 RID: 106807 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A137")]
		[Address(RVA = "0x12EAF40", Offset = "0x12E9B40", VA = "0x1812EAF40")]
		public void Render(SandboxV2DungeonMiscExpeditionViewModel expeditionViewModel)
		{
		}

		// Token: 0x0601A138 RID: 106808 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A138")]
		[Address(RVA = "0x12EB170", Offset = "0x12E9D70", VA = "0x1812EB170")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601A139 RID: 106809 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A139")]
		[Address(RVA = "0x12EB290", Offset = "0x12E9E90", VA = "0x1812EB290")]
		public SandboxV2DungeonExpeditionEffectView()
		{
		}

		// Token: 0x04020DA1 RID: 134561
		[Token(Token = "0x4020DA1")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SimpleLayoutContent _content;

		// Token: 0x04020DA2 RID: 134562
		[Token(Token = "0x4020DA2")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _title;

		// Token: 0x04020DA3 RID: 134563
		[Token(Token = "0x4020DA3")]
		[FieldOffset(Offset = "0x28")]
		private bool m_isInited;

		// Token: 0x04020DA4 RID: 134564
		[Token(Token = "0x4020DA4")]
		[FieldOffset(Offset = "0x30")]
		private SandboxV2DungeonExpeditionEffectView.Adapter m_adapter;

		// Token: 0x04020DA5 RID: 134565
		[Token(Token = "0x4020DA5")]
		[FieldOffset(Offset = "0x38")]
		private SandboxV2DungeonMiscExpeditionViewModel m_cachedViewModel;

		// Token: 0x04020DA6 RID: 134566
		[Token(Token = "0x4020DA6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04020DA7 RID: 134567
		[Token(Token = "0x4020DA7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04020DA8 RID: 134568
		[Token(Token = "0x4020DA8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004203 RID: 16899
		[Token(Token = "0x2004203")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x0601A13A RID: 106810 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601A13A")]
			[Address(RVA = "0x12E6780", Offset = "0x12E5380", VA = "0x1812E6780")]
			public Adapter(SandboxV2DungeonExpeditionEffectView closure)
			{
			}

			// Token: 0x17003E13 RID: 15891
			// (get) Token: 0x0601A13B RID: 106811 RVA: 0x000A03B0 File Offset: 0x0009E5B0
			[Token(Token = "0x17003E13")]
			public override int count
			{
				[Token(Token = "0x601A13B")]
				[Address(RVA = "0x12E6AD0", Offset = "0x12E56D0", VA = "0x1812E6AD0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601A13C RID: 106812 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601A13C")]
			[Address(RVA = "0x12E6170", Offset = "0x12E4D70", VA = "0x1812E6170", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x04020DA9 RID: 134569
			[Token(Token = "0x4020DA9")]
			[FieldOffset(Offset = "0x20")]
			private SandboxV2DungeonExpeditionEffectView m_closure;

			// Token: 0x04020DAA RID: 134570
			[Token(Token = "0x4020DAA")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04020DAB RID: 134571
			[Token(Token = "0x4020DAB")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04020DAC RID: 134572
			[Token(Token = "0x4020DAC")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
