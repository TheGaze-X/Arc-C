using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.AVG
{
	// Token: 0x02001F20 RID: 7968
	[Token(Token = "0x2001F20")]
	public class AVGReaderModeCgItemView : MonoBehaviour, IAVGDataSubscriber<AVGReaderModePerformanceViewModel>, IHotfixable
	{
		// Token: 0x0600C60D RID: 50701 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C60D")]
		[Address(RVA = "0x34663A0", Offset = "0x3464FA0", VA = "0x1834663A0", Slot = "4")]
		public void OnValueChanged(AVGReaderModePerformanceViewModel viewModel)
		{
		}

		// Token: 0x0600C60E RID: 50702 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C60E")]
		[Address(RVA = "0x3466610", Offset = "0x3465210", VA = "0x183466610")]
		public void RenderView(Command command)
		{
		}

		// Token: 0x0600C60F RID: 50703 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C60F")]
		[Address(RVA = "0x3467050", Offset = "0x3465C50", VA = "0x183467050")]
		private void _ExecuteShowItem(Command command)
		{
		}

		// Token: 0x0600C610 RID: 50704 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C610")]
		[Address(RVA = "0x3466F30", Offset = "0x3465B30", VA = "0x183466F30")]
		private void _ExecuteHideItem(Command command)
		{
		}

		// Token: 0x0600C611 RID: 50705 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C611")]
		[Address(RVA = "0x34679E0", Offset = "0x34665E0", VA = "0x1834679E0")]
		private void _ShowItem(Command command)
		{
		}

		// Token: 0x0600C612 RID: 50706 RVA: 0x00048708 File Offset: 0x00046908
		[Token(Token = "0x600C612")]
		[Address(RVA = "0x3467330", Offset = "0x3465F30", VA = "0x183467330")]
		private AVGReaderModeCgItemView.CgItemParam _GenParamWithCommand(Command command)
		{
			return default(AVGReaderModeCgItemView.CgItemParam);
		}

		// Token: 0x0600C613 RID: 50707 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C613")]
		[Address(RVA = "0x3466920", Offset = "0x3465520", VA = "0x183466920")]
		private Command _BuildCgItemRenderCommand(Command command, Vector2? position)
		{
			return null;
		}

		// Token: 0x0600C614 RID: 50708 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C614")]
		[Address(RVA = "0x34671D0", Offset = "0x3465DD0", VA = "0x1834671D0")]
		private AVGReaderModeCgItemView.SlotStyle _FindSlotStyle(string style)
		{
			return null;
		}

		// Token: 0x0600C615 RID: 50709 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C615")]
		[Address(RVA = "0x34676D0", Offset = "0x34662D0", VA = "0x1834676D0")]
		private Sprite _LoadSprite(string key)
		{
			return null;
		}

		// Token: 0x0600C616 RID: 50710 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C616")]
		[Address(RVA = "0x3467900", Offset = "0x3466500", VA = "0x183467900")]
		private void _Reset()
		{
		}

		// Token: 0x0600C617 RID: 50711 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C617")]
		[Address(RVA = "0x3466340", Offset = "0x3464F40", VA = "0x183466340")]
		private void OnDisable()
		{
		}

		// Token: 0x0600C618 RID: 50712 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C618")]
		[Address(RVA = "0x34662E0", Offset = "0x3464EE0", VA = "0x1834662E0")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600C619 RID: 50713 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C619")]
		[Address(RVA = "0x3467860", Offset = "0x3466460", VA = "0x183467860")]
		private void _ResetCommandCache()
		{
		}

		// Token: 0x0600C61A RID: 50714 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C61A")]
		[Address(RVA = "0x3467790", Offset = "0x3466390", VA = "0x183467790")]
		private Command _PickLatestShowHideCommand(Command showCommand, Command hideCommand)
		{
			return null;
		}

		// Token: 0x0600C61B RID: 50715 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C61B")]
		[Address(RVA = "0x3467E70", Offset = "0x3466A70", VA = "0x183467E70")]
		public AVGReaderModeCgItemView()
		{
		}

		// Token: 0x0400CB03 RID: 51971
		[Token(Token = "0x400CB03")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private AVGReaderModeCgItemView.SlotStyle[] _slotStyles;

		// Token: 0x0400CB04 RID: 51972
		[Token(Token = "0x400CB04")]
		[FieldOffset(Offset = "0x20")]
		private AVGShowItemSlot m_slotInUse;

		// Token: 0x0400CB05 RID: 51973
		[Token(Token = "0x400CB05")]
		[FieldOffset(Offset = "0x28")]
		private HashSet<int> m_processedLineNumbers;

		// Token: 0x0400CB06 RID: 51974
		[Token(Token = "0x400CB06")]
		[FieldOffset(Offset = "0x30")]
		private Dictionary<string, Command> m_lastCommandDict;

		// Token: 0x0400CB07 RID: 51975
		[Token(Token = "0x400CB07")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0400CB08 RID: 51976
		[Token(Token = "0x400CB08")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RenderView;

		// Token: 0x0400CB09 RID: 51977
		[Token(Token = "0x400CB09")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__ExecuteShowItem;

		// Token: 0x0400CB0A RID: 51978
		[Token(Token = "0x400CB0A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__ExecuteHideItem;

		// Token: 0x0400CB0B RID: 51979
		[Token(Token = "0x400CB0B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__ShowItem;

		// Token: 0x0400CB0C RID: 51980
		[Token(Token = "0x400CB0C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__GenParamWithCommand;

		// Token: 0x0400CB0D RID: 51981
		[Token(Token = "0x400CB0D")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__BuildCgItemRenderCommand;

		// Token: 0x0400CB0E RID: 51982
		[Token(Token = "0x400CB0E")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__FindSlotStyle;

		// Token: 0x0400CB0F RID: 51983
		[Token(Token = "0x400CB0F")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__LoadSprite;

		// Token: 0x0400CB10 RID: 51984
		[Token(Token = "0x400CB10")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__Reset;

		// Token: 0x0400CB11 RID: 51985
		[Token(Token = "0x400CB11")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnDisable;

		// Token: 0x0400CB12 RID: 51986
		[Token(Token = "0x400CB12")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0400CB13 RID: 51987
		[Token(Token = "0x400CB13")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__ResetCommandCache;

		// Token: 0x0400CB14 RID: 51988
		[Token(Token = "0x400CB14")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__PickLatestShowHideCommand;

		// Token: 0x0400CB15 RID: 51989
		[Token(Token = "0x400CB15")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001F21 RID: 7969
		[Token(Token = "0x2001F21")]
		public struct CgItemParam
		{
			// Token: 0x0400CB16 RID: 51990
			[Token(Token = "0x400CB16")]
			[FieldOffset(Offset = "0x0")]
			public string style;

			// Token: 0x0400CB17 RID: 51991
			[Token(Token = "0x400CB17")]
			[FieldOffset(Offset = "0x8")]
			public string image;

			// Token: 0x0400CB18 RID: 51992
			[Token(Token = "0x400CB18")]
			[FieldOffset(Offset = "0x10")]
			public Vector2? position;
		}

		// Token: 0x02001F22 RID: 7970
		[Token(Token = "0x2001F22")]
		[Serializable]
		private class SlotStyle
		{
			// Token: 0x0600C61D RID: 50717 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C61D")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public SlotStyle()
			{
			}

			// Token: 0x0400CB19 RID: 51993
			[Token(Token = "0x400CB19")]
			[FieldOffset(Offset = "0x10")]
			public string styleKey;

			// Token: 0x0400CB1A RID: 51994
			[Token(Token = "0x400CB1A")]
			[FieldOffset(Offset = "0x18")]
			public GameObject slotPrefab;
		}
	}
}
