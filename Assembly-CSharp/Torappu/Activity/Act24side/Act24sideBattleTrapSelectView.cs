using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.Atlas;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act24side
{
	// Token: 0x0200756E RID: 30062
	[Token(Token = "0x200756E")]
	public class Act24sideBattleTrapSelectView : Act24sideBattleTrapAbstractSelectView
	{
		// Token: 0x0602A52F RID: 173359 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A52F")]
		[Address(RVA = "0x25F7D30", Offset = "0x25F6930", VA = "0x1825F7D30", Slot = "4")]
		public override void Render(Act24sideBattleTrapViewModel model)
		{
		}

		// Token: 0x0602A530 RID: 173360 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A530")]
		[Address(RVA = "0x25F8170", Offset = "0x25F6D70", VA = "0x1825F8170")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602A531 RID: 173361 RVA: 0x000D8078 File Offset: 0x000D6278
		[Token(Token = "0x602A531")]
		[Address(RVA = "0x25F8060", Offset = "0x25F6C60", VA = "0x1825F8060")]
		private SpriteRenderData _GetCurTakeCountSprite(int takeCount, int maxCount)
		{
			return default(SpriteRenderData);
		}

		// Token: 0x0602A532 RID: 173362 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A532")]
		[Address(RVA = "0x25F8290", Offset = "0x25F6E90", VA = "0x1825F8290")]
		public Act24sideBattleTrapSelectView()
		{
		}

		// Token: 0x0403CDDA RID: 249306
		[Token(Token = "0x403CDDA")]
		private const string IMG_TAKE_COUNT_PREFIX = "take_count_{0}";

		// Token: 0x0403CDDB RID: 249307
		[Token(Token = "0x403CDDB")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIAtlasObject _atlas;

		// Token: 0x0403CDDC RID: 249308
		[Token(Token = "0x403CDDC")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIAtlasImage _imgCurTakeCount;

		// Token: 0x0403CDDD RID: 249309
		[Token(Token = "0x403CDDD")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SimpleLayoutContent _trapSmallIconList;

		// Token: 0x0403CDDE RID: 249310
		[Token(Token = "0x403CDDE")]
		[FieldOffset(Offset = "0x30")]
		private bool m_hasInited;

		// Token: 0x0403CDDF RID: 249311
		[Token(Token = "0x403CDDF")]
		[FieldOffset(Offset = "0x38")]
		private List<Act24sideBattleTrapItemViewModel> m_itemList;

		// Token: 0x0403CDE0 RID: 249312
		[Token(Token = "0x403CDE0")]
		[FieldOffset(Offset = "0x40")]
		private Act24sideBattleTrapSelectView.TrapSmallIconListAdapter m_trapSmallIconListAdapter;

		// Token: 0x0403CDE1 RID: 249313
		[Token(Token = "0x403CDE1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403CDE2 RID: 249314
		[Token(Token = "0x403CDE2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403CDE3 RID: 249315
		[Token(Token = "0x403CDE3")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__GetCurTakeCountSprite;

		// Token: 0x0403CDE4 RID: 249316
		[Token(Token = "0x403CDE4")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200756F RID: 30063
		[Token(Token = "0x200756F")]
		private class TrapSmallIconListAdapter : SimpleLayoutAdapter
		{
			// Token: 0x0602A533 RID: 173363 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602A533")]
			[Address(RVA = "0x2604B70", Offset = "0x2603770", VA = "0x182604B70")]
			public TrapSmallIconListAdapter(Act24sideBattleTrapSelectView closure)
			{
			}

			// Token: 0x170063A6 RID: 25510
			// (get) Token: 0x0602A534 RID: 173364 RVA: 0x000D8090 File Offset: 0x000D6290
			[Token(Token = "0x170063A6")]
			public override int count
			{
				[Token(Token = "0x602A534")]
				[Address(RVA = "0x2604BF0", Offset = "0x26037F0", VA = "0x182604BF0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0602A535 RID: 173365 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602A535")]
			[Address(RVA = "0x26049C0", Offset = "0x26035C0", VA = "0x1826049C0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0403CDE5 RID: 249317
			[Token(Token = "0x403CDE5")]
			[FieldOffset(Offset = "0x20")]
			private Act24sideBattleTrapSelectView m_closure;

			// Token: 0x0403CDE6 RID: 249318
			[Token(Token = "0x403CDE6")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0403CDE7 RID: 249319
			[Token(Token = "0x403CDE7")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0403CDE8 RID: 249320
			[Token(Token = "0x403CDE8")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
