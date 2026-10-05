using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.RoguelikeTopic.RL01
{
	// Token: 0x02004635 RID: 17973
	[Token(Token = "0x2004635")]
	public class RL01DifficultyItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601B4C2 RID: 111810 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B4C2")]
		[Address(RVA = "0x149A060", Offset = "0x1498C60", VA = "0x18149A060")]
		public void Render(RL01DifficultyItem.ViewData data)
		{
		}

		// Token: 0x0601B4C3 RID: 111811 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B4C3")]
		[Address(RVA = "0x149A800", Offset = "0x1499400", VA = "0x18149A800")]
		public void UpdateState(RL01DifficultyItem.ViewData data, bool include, bool select, bool immediately)
		{
		}

		// Token: 0x0601B4C4 RID: 111812 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B4C4")]
		[Address(RVA = "0x1499FE0", Offset = "0x1498BE0", VA = "0x181499FE0")]
		public void EventOnClick()
		{
		}

		// Token: 0x0601B4C5 RID: 111813 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B4C5")]
		[Address(RVA = "0x149AAC0", Offset = "0x14996C0", VA = "0x18149AAC0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601B4C6 RID: 111814 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B4C6")]
		[Address(RVA = "0x149AC40", Offset = "0x1499840", VA = "0x18149AC40")]
		public RL01DifficultyItem()
		{
		}

		// Token: 0x040233F6 RID: 144374
		[Token(Token = "0x40233F6")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _normalTitle;

		// Token: 0x040233F7 RID: 144375
		[Token(Token = "0x40233F7")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _hardTitle;

		// Token: 0x040233F8 RID: 144376
		[Token(Token = "0x40233F8")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _name;

		// Token: 0x040233F9 RID: 144377
		[Token(Token = "0x40233F9")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _subName;

		// Token: 0x040233FA RID: 144378
		[Token(Token = "0x40233FA")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _gradeLvl;

		// Token: 0x040233FB RID: 144379
		[Token(Token = "0x40233FB")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private SimpleLayoutContent _descList;

		// Token: 0x040233FC RID: 144380
		[Token(Token = "0x40233FC")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Color _descNormalColor;

		// Token: 0x040233FD RID: 144381
		[Token(Token = "0x40233FD")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Color _descBuffColor;

		// Token: 0x040233FE RID: 144382
		[Token(Token = "0x40233FE")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _warnningTag;

		// Token: 0x040233FF RID: 144383
		[Token(Token = "0x40233FF")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _lockedTag;

		// Token: 0x04023400 RID: 144384
		[Token(Token = "0x4023400")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Text _lockedDesc;

		// Token: 0x04023401 RID: 144385
		[Token(Token = "0x4023401")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject _newTag;

		// Token: 0x04023402 RID: 144386
		[Token(Token = "0x4023402")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private RoguelikeTopicDifficultyItemColors[] _stateClrTargets;

		// Token: 0x04023403 RID: 144387
		[Token(Token = "0x4023403")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private RoguelikeTopicDifficultyItemColors[] _mainClrTargets;

		// Token: 0x04023404 RID: 144388
		[Token(Token = "0x4023404")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Image _colorLine;

		// Token: 0x04023405 RID: 144389
		[Token(Token = "0x4023405")]
		[FieldOffset(Offset = "0xA0")]
		private bool m_inited;

		// Token: 0x04023406 RID: 144390
		[Token(Token = "0x4023406")]
		[FieldOffset(Offset = "0xA8")]
		private Action<int> m_onClick;

		// Token: 0x04023407 RID: 144391
		[Token(Token = "0x4023407")]
		[FieldOffset(Offset = "0xB0")]
		private int m_index;

		// Token: 0x04023408 RID: 144392
		[Token(Token = "0x4023408")]
		[FieldOffset(Offset = "0xB8")]
		private RL01DifficultyItem.DescListAdapter m_descAdapter;

		// Token: 0x04023409 RID: 144393
		[Token(Token = "0x4023409")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402340A RID: 144394
		[Token(Token = "0x402340A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateState;

		// Token: 0x0402340B RID: 144395
		[Token(Token = "0x402340B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EventOnClick;

		// Token: 0x0402340C RID: 144396
		[Token(Token = "0x402340C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402340D RID: 144397
		[Token(Token = "0x402340D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004636 RID: 17974
		[Token(Token = "0x2004636")]
		public struct ViewData
		{
			// Token: 0x0402340E RID: 144398
			[Token(Token = "0x402340E")]
			[FieldOffset(Offset = "0x0")]
			public RL01DifficultyItem prefab;

			// Token: 0x0402340F RID: 144399
			[Token(Token = "0x402340F")]
			[FieldOffset(Offset = "0x8")]
			public RL01DifficultyViewModel itemModel;

			// Token: 0x04023410 RID: 144400
			[Token(Token = "0x4023410")]
			[FieldOffset(Offset = "0x10")]
			public int pageIndex;

			// Token: 0x04023411 RID: 144401
			[Token(Token = "0x4023411")]
			[FieldOffset(Offset = "0x18")]
			public Action<int> onItemClicked;
		}

		// Token: 0x02004637 RID: 17975
		[Token(Token = "0x2004637")]
		public class VirtualView : UIRecycleLayoutAdapter.VirtualView<RL01DifficultyItem>
		{
			// Token: 0x0601B4C7 RID: 111815 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B4C7")]
			[Address(RVA = "0x14AAD70", Offset = "0x14A9970", VA = "0x1814AAD70")]
			public VirtualView(RL01DifficultyItem.ViewData data)
			{
			}

			// Token: 0x0601B4C8 RID: 111816 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601B4C8")]
			[Address(RVA = "0x14AAA00", Offset = "0x14A9600", VA = "0x1814AAA00", Slot = "12")]
			public override GameObject GetPrefab()
			{
				return null;
			}

			// Token: 0x0601B4C9 RID: 111817 RVA: 0x000A4D60 File Offset: 0x000A2F60
			[Token(Token = "0x601B4C9")]
			[Address(RVA = "0x14AAA70", Offset = "0x14A9670", VA = "0x1814AAA70", Slot = "13")]
			public override float GetPreferSize()
			{
				return 0f;
			}

			// Token: 0x0601B4CA RID: 111818 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B4CA")]
			[Address(RVA = "0x14AAB00", Offset = "0x14A9700", VA = "0x1814AAB00", Slot = "10")]
			protected override void OnViewAttached()
			{
			}

			// Token: 0x0601B4CB RID: 111819 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B4CB")]
			[Address(RVA = "0x14AAC00", Offset = "0x14A9800", VA = "0x1814AAC00", Slot = "11")]
			protected override void OnViewDetached()
			{
			}

			// Token: 0x0601B4CC RID: 111820 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B4CC")]
			[Address(RVA = "0x14AAC60", Offset = "0x14A9860", VA = "0x1814AAC60")]
			public void UpdateState(int selectPage)
			{
			}

			// Token: 0x04023412 RID: 144402
			[Token(Token = "0x4023412")]
			[FieldOffset(Offset = "0x20")]
			private RL01DifficultyItem.ViewData m_data;

			// Token: 0x04023413 RID: 144403
			[Token(Token = "0x4023413")]
			[FieldOffset(Offset = "0x40")]
			private int m_selectPage;

			// Token: 0x04023414 RID: 144404
			[Token(Token = "0x4023414")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04023415 RID: 144405
			[Token(Token = "0x4023415")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GetPrefab;

			// Token: 0x04023416 RID: 144406
			[Token(Token = "0x4023416")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GetPreferSize;

			// Token: 0x04023417 RID: 144407
			[Token(Token = "0x4023417")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_OnViewAttached;

			// Token: 0x04023418 RID: 144408
			[Token(Token = "0x4023418")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_OnViewDetached;

			// Token: 0x04023419 RID: 144409
			[Token(Token = "0x4023419")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_UpdateState;
		}

		// Token: 0x02004638 RID: 17976
		[Token(Token = "0x2004638")]
		private class DescListAdapter : SimpleLayoutAdapter
		{
			// Token: 0x0601B4CD RID: 111821 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B4CD")]
			[Address(RVA = "0x1496540", Offset = "0x1495140", VA = "0x181496540")]
			public DescListAdapter(RL01DifficultyItem item)
			{
			}

			// Token: 0x1700410E RID: 16654
			// (get) Token: 0x0601B4CE RID: 111822 RVA: 0x000A4D78 File Offset: 0x000A2F78
			[Token(Token = "0x1700410E")]
			public override int count
			{
				[Token(Token = "0x601B4CE")]
				[Address(RVA = "0x1496610", Offset = "0x1495210", VA = "0x181496610", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601B4CF RID: 111823 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601B4CF")]
			[Address(RVA = "0x1496190", Offset = "0x1494D90", VA = "0x181496190", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0601B4D0 RID: 111824 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B4D0")]
			[Address(RVA = "0x14963C0", Offset = "0x1494FC0", VA = "0x1814963C0")]
			public void Switch(RoguelikeTopicDifficultyItemStatus stateName, bool immediately)
			{
			}

			// Token: 0x0402341A RID: 144410
			[Token(Token = "0x402341A")]
			[FieldOffset(Offset = "0x20")]
			private RL01DifficultyItem m_item;

			// Token: 0x0402341B RID: 144411
			[Token(Token = "0x402341B")]
			[FieldOffset(Offset = "0x28")]
			public List<string> descriptions;

			// Token: 0x0402341C RID: 144412
			[Token(Token = "0x402341C")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402341D RID: 144413
			[Token(Token = "0x402341D")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0402341E RID: 144414
			[Token(Token = "0x402341E")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x0402341F RID: 144415
			[Token(Token = "0x402341F")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_Switch;
		}

		// Token: 0x02004639 RID: 17977
		[Token(Token = "0x2004639")]
		public static class StateNames
		{
			// Token: 0x04023420 RID: 144416
			[Token(Token = "0x4023420")]
			[FieldOffset(Offset = "0x0")]
			public static string INCLUDE;

			// Token: 0x04023421 RID: 144417
			[Token(Token = "0x4023421")]
			[FieldOffset(Offset = "0x8")]
			public static string SELECTED;

			// Token: 0x04023422 RID: 144418
			[Token(Token = "0x4023422")]
			[FieldOffset(Offset = "0x10")]
			public static string EXCLUSIVE;
		}
	}
}
