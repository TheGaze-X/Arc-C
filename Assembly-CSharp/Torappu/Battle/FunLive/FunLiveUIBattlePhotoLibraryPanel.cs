using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Battle.FunLive
{
	// Token: 0x0200268E RID: 9870
	[Token(Token = "0x200268E")]
	public class FunLiveUIBattlePhotoLibraryPanel : MonoBehaviour, IHotfixable
	{
		// Token: 0x060101E7 RID: 66023 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60101E7")]
		[Address(RVA = "0x7C5AF0", Offset = "0x7C46F0", VA = "0x1807C5AF0")]
		public void Init(FunLiveUIPhotoLibraryState state, List<string> eventList)
		{
		}

		// Token: 0x060101E8 RID: 66024 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60101E8")]
		[Address(RVA = "0x7C5EF0", Offset = "0x7C4AF0", VA = "0x1807C5EF0")]
		public void Show()
		{
		}

		// Token: 0x060101E9 RID: 66025 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60101E9")]
		[Address(RVA = "0x7C5A80", Offset = "0x7C4680", VA = "0x1807C5A80")]
		public void ClosePhotoLibraryPanel()
		{
		}

		// Token: 0x060101EA RID: 66026 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60101EA")]
		[Address(RVA = "0x7C60C0", Offset = "0x7C4CC0", VA = "0x1807C60C0")]
		public FunLiveUIBattlePhotoLibraryPanel()
		{
		}

		// Token: 0x04011F58 RID: 73560
		[Token(Token = "0x4011F58")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _photoCnt;

		// Token: 0x04011F59 RID: 73561
		[Token(Token = "0x4011F59")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SimpleLayoutContent _photoList;

		// Token: 0x04011F5A RID: 73562
		[Token(Token = "0x4011F5A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("PosSet")]
		private RectTransform _photoListScrollView;

		// Token: 0x04011F5B RID: 73563
		[Token(Token = "0x4011F5B")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("PosSet")]
		private ContentSizeFitter _contentFitter;

		// Token: 0x04011F5C RID: 73564
		[Token(Token = "0x4011F5C")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("PosSet")]
		private RectTransform _grid;

		// Token: 0x04011F5D RID: 73565
		[Token(Token = "0x4011F5D")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("PosSet")]
		private GameObject _nodataImage;

		// Token: 0x04011F5E RID: 73566
		[Token(Token = "0x4011F5E")]
		[FieldOffset(Offset = "0x48")]
		private FunLiveUIPlugin m_plugin;

		// Token: 0x04011F5F RID: 73567
		[Token(Token = "0x4011F5F")]
		[FieldOffset(Offset = "0x50")]
		private FunLiveUIPhotoLibraryState m_state;

		// Token: 0x04011F60 RID: 73568
		[Token(Token = "0x4011F60")]
		[FieldOffset(Offset = "0x58")]
		private FunLiveUIBattlePhotoLibraryPanel.CardListAdapter m_photoListAdapter;

		// Token: 0x04011F61 RID: 73569
		[Token(Token = "0x4011F61")]
		[FieldOffset(Offset = "0x60")]
		private List<string> m_photoList;

		// Token: 0x04011F62 RID: 73570
		[Token(Token = "0x4011F62")]
		[FieldOffset(Offset = "0x68")]
		private CanvasGroup m_svCanScroll;

		// Token: 0x04011F63 RID: 73571
		[Token(Token = "0x4011F63")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04011F64 RID: 73572
		[Token(Token = "0x4011F64")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Show;

		// Token: 0x04011F65 RID: 73573
		[Token(Token = "0x4011F65")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ClosePhotoLibraryPanel;

		// Token: 0x04011F66 RID: 73574
		[Token(Token = "0x4011F66")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200268F RID: 9871
		[Token(Token = "0x200268F")]
		private class CardListAdapter : SimpleLayoutAdapter
		{
			// Token: 0x060101EB RID: 66027 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60101EB")]
			[Address(RVA = "0x7E2280", Offset = "0x7E0E80", VA = "0x1807E2280")]
			public CardListAdapter(FunLiveUIBattlePhotoLibraryPanel closure)
			{
			}

			// Token: 0x1700231E RID: 8990
			// (get) Token: 0x060101EC RID: 66028 RVA: 0x000624A8 File Offset: 0x000606A8
			[Token(Token = "0x1700231E")]
			public override int count
			{
				[Token(Token = "0x60101EC")]
				[Address(RVA = "0x7E2300", Offset = "0x7E0F00", VA = "0x1807E2300", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x060101ED RID: 66029 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60101ED")]
			[Address(RVA = "0x7E20D0", Offset = "0x7E0CD0", VA = "0x1807E20D0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x04011F67 RID: 73575
			[Token(Token = "0x4011F67")]
			[FieldOffset(Offset = "0x20")]
			private FunLiveUIBattlePhotoLibraryPanel m_closure;

			// Token: 0x04011F68 RID: 73576
			[Token(Token = "0x4011F68")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04011F69 RID: 73577
			[Token(Token = "0x4011F69")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04011F6A RID: 73578
			[Token(Token = "0x4011F6A")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
