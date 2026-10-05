using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004312 RID: 17170
	[Token(Token = "0x2004312")]
	public class SandboxV2ChallengeRewardItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17003E95 RID: 16021
		// (get) Token: 0x0601A600 RID: 108032 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601A601 RID: 108033 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003E95")]
		public Action<string> onReceiveClicked
		{
			[Token(Token = "0x601A600")]
			[Address(RVA = "0x13430C0", Offset = "0x1341CC0", VA = "0x1813430C0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601A601")]
			[Address(RVA = "0x1343120", Offset = "0x1341D20", VA = "0x181343120")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0601A602 RID: 108034 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A602")]
		[Address(RVA = "0x1342F10", Offset = "0x1341B10", VA = "0x181342F10")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601A603 RID: 108035 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A603")]
		[Address(RVA = "0x1342B40", Offset = "0x1341740", VA = "0x181342B40")]
		public void Render(SandboxV2ChallengeRewardDialog.SandboxV2ChallengeRewardViewModel viewModel)
		{
		}

		// Token: 0x0601A604 RID: 108036 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A604")]
		[Address(RVA = "0x1342A90", Offset = "0x1341690", VA = "0x181342A90")]
		public void OnReceiveClicked()
		{
		}

		// Token: 0x0601A605 RID: 108037 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A605")]
		[Address(RVA = "0x1343050", Offset = "0x1341C50", VA = "0x181343050")]
		public SandboxV2ChallengeRewardItemView()
		{
		}

		// Token: 0x040217DB RID: 137179
		[Token(Token = "0x40217DB")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _pnlComplete;

		// Token: 0x040217DC RID: 137180
		[Token(Token = "0x40217DC")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _pnlIncomplete;

		// Token: 0x040217DD RID: 137181
		[Token(Token = "0x40217DD")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _pnlReceived;

		// Token: 0x040217DE RID: 137182
		[Token(Token = "0x40217DE")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textDay;

		// Token: 0x040217DF RID: 137183
		[Token(Token = "0x40217DF")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textDesc;

		// Token: 0x040217E0 RID: 137184
		[Token(Token = "0x40217E0")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Color _colorDayComplete;

		// Token: 0x040217E1 RID: 137185
		[Token(Token = "0x40217E1")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Color _colorDayIncomplete;

		// Token: 0x040217E2 RID: 137186
		[Token(Token = "0x40217E2")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Color _colorDescComplete;

		// Token: 0x040217E3 RID: 137187
		[Token(Token = "0x40217E3")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Color _colorDescIncomplete;

		// Token: 0x040217E4 RID: 137188
		[Token(Token = "0x40217E4")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private SimpleLayoutContent _rewardContainer;

		// Token: 0x040217E5 RID: 137189
		[Token(Token = "0x40217E5")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private float _itemCardScale;

		// Token: 0x040217E6 RID: 137190
		[Token(Token = "0x40217E6")]
		[FieldOffset(Offset = "0x90")]
		private List<ItemBundle> m_cachedRewardList;

		// Token: 0x040217E7 RID: 137191
		[Token(Token = "0x40217E7")]
		[FieldOffset(Offset = "0x98")]
		private SandboxV2ChallengeRewardItemView.Adapter m_adapter;

		// Token: 0x040217E8 RID: 137192
		[Token(Token = "0x40217E8")]
		[FieldOffset(Offset = "0xA0")]
		private bool m_inited;

		// Token: 0x040217E9 RID: 137193
		[Token(Token = "0x40217E9")]
		[FieldOffset(Offset = "0xA4")]
		private SandboxV2ChallengeRewardDialog.SandboxV2ChallengeRewardViewModel.State m_cachedState;

		// Token: 0x040217EA RID: 137194
		[Token(Token = "0x40217EA")]
		[FieldOffset(Offset = "0xA8")]
		private string m_cachedRewardId;

		// Token: 0x040217EC RID: 137196
		[Token(Token = "0x40217EC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onReceiveClicked;

		// Token: 0x040217ED RID: 137197
		[Token(Token = "0x40217ED")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onReceiveClicked;

		// Token: 0x040217EE RID: 137198
		[Token(Token = "0x40217EE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040217EF RID: 137199
		[Token(Token = "0x40217EF")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040217F0 RID: 137200
		[Token(Token = "0x40217F0")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnReceiveClicked;

		// Token: 0x040217F1 RID: 137201
		[Token(Token = "0x40217F1")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004313 RID: 17171
		[Token(Token = "0x2004313")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x17003E96 RID: 16022
			// (get) Token: 0x0601A606 RID: 108038 RVA: 0x000A19B8 File Offset: 0x0009FBB8
			[Token(Token = "0x17003E96")]
			public override int count
			{
				[Token(Token = "0x601A606")]
				[Address(RVA = "0x1340000", Offset = "0x133EC00", VA = "0x181340000", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601A607 RID: 108039 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601A607")]
			[Address(RVA = "0x133FD60", Offset = "0x133E960", VA = "0x18133FD60")]
			public Adapter(SandboxV2ChallengeRewardItemView closure)
			{
			}

			// Token: 0x0601A608 RID: 108040 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601A608")]
			[Address(RVA = "0x133F680", Offset = "0x133E280", VA = "0x18133F680", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x040217F2 RID: 137202
			[Token(Token = "0x40217F2")]
			[FieldOffset(Offset = "0x20")]
			private SandboxV2ChallengeRewardItemView m_closure;

			// Token: 0x040217F3 RID: 137203
			[Token(Token = "0x40217F3")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x040217F4 RID: 137204
			[Token(Token = "0x40217F4")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x040217F5 RID: 137205
			[Token(Token = "0x40217F5")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
