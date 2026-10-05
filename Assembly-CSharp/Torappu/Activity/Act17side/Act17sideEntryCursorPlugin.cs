using System;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.ActivityStage;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act17side
{
	// Token: 0x020079AC RID: 31148
	[Token(Token = "0x20079AC")]
	public class Act17sideEntryCursorPlugin : TemplateActivityCommonPlugin
	{
		// Token: 0x0602BB15 RID: 178965 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BB15")]
		[Address(RVA = "0x27A3E90", Offset = "0x27A2A90", VA = "0x1827A3E90")]
		private void _InitIfNot(string activityId)
		{
		}

		// Token: 0x0602BB16 RID: 178966 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602BB16")]
		[Address(RVA = "0x27A35D0", Offset = "0x27A21D0", VA = "0x1827A35D0")]
		private Tween _GenerateTweenOfEntry(bool backFromBatlle)
		{
			return null;
		}

		// Token: 0x0602BB17 RID: 178967 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602BB17")]
		[Address(RVA = "0x27A3960", Offset = "0x27A2560", VA = "0x1827A3960")]
		private Tween _GenerateTweenOfZoneSelected()
		{
			return null;
		}

		// Token: 0x0602BB18 RID: 178968 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BB18")]
		[Address(RVA = "0x27A40F0", Offset = "0x27A2CF0", VA = "0x1827A40F0")]
		private void _OpenRPPage(string zoneId)
		{
		}

		// Token: 0x0602BB19 RID: 178969 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BB19")]
		[Address(RVA = "0x27A3160", Offset = "0x27A1D60", VA = "0x1827A3160")]
		public void OnLoaded()
		{
		}

		// Token: 0x0602BB1A RID: 178970 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BB1A")]
		[Address(RVA = "0x27A32B0", Offset = "0x27A1EB0", VA = "0x1827A32B0", Slot = "5")]
		public override void OnViewModelRefresh(TemplateActivityViewModel viewModel)
		{
		}

		// Token: 0x0602BB1B RID: 178971 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BB1B")]
		[Address(RVA = "0x27A4370", Offset = "0x27A2F70", VA = "0x1827A4370")]
		public Act17sideEntryCursorPlugin()
		{
		}

		// Token: 0x0403F367 RID: 258919
		[Token(Token = "0x403F367")]
		private const string DEFAULT_POS_KEY = "default";

		// Token: 0x0403F368 RID: 258920
		[Token(Token = "0x403F368")]
		public const string LAST_OPEN_ZONE_KEY = "{0}_last_open_zone";

		// Token: 0x0403F369 RID: 258921
		[Token(Token = "0x403F369")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<Act17sideEntryCursorPlugin.Act17sideEntryCursorItem> _cursorItems;

		// Token: 0x0403F36A RID: 258922
		[Token(Token = "0x403F36A")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RectTransform _cursor;

		// Token: 0x0403F36B RID: 258923
		[Token(Token = "0x403F36B")]
		[FieldOffset(Offset = "0x38")]
		private Tween m_tween;

		// Token: 0x0403F36C RID: 258924
		[Token(Token = "0x403F36C")]
		[FieldOffset(Offset = "0x40")]
		private bool m_hasPlayedEntryAnim;

		// Token: 0x0403F36D RID: 258925
		[Token(Token = "0x403F36D")]
		[FieldOffset(Offset = "0x48")]
		private Dictionary<string, Act17sideEntryCursorPlugin.Act17sideEntryCursorItem> m_cursorMap;

		// Token: 0x0403F36E RID: 258926
		[Token(Token = "0x403F36E")]
		[FieldOffset(Offset = "0x50")]
		private string m_activityId;

		// Token: 0x0403F36F RID: 258927
		[Token(Token = "0x403F36F")]
		[FieldOffset(Offset = "0x58")]
		private Act17sideActivityZoneGroupViewModel m_cachedViewModel;

		// Token: 0x0403F370 RID: 258928
		[Token(Token = "0x403F370")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403F371 RID: 258929
		[Token(Token = "0x403F371")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__GenerateTweenOfEntry;

		// Token: 0x0403F372 RID: 258930
		[Token(Token = "0x403F372")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__GenerateTweenOfZoneSelected;

		// Token: 0x0403F373 RID: 258931
		[Token(Token = "0x403F373")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OpenRPPage;

		// Token: 0x0403F374 RID: 258932
		[Token(Token = "0x403F374")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnLoaded;

		// Token: 0x0403F375 RID: 258933
		[Token(Token = "0x403F375")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnViewModelRefresh;

		// Token: 0x0403F376 RID: 258934
		[Token(Token = "0x403F376")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020079AD RID: 31149
		[Token(Token = "0x20079AD")]
		[Serializable]
		public class Act17sideEntryCursorItem
		{
			// Token: 0x0602BB1C RID: 178972 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602BB1C")]
			[Address(RVA = "0x27A30D0", Offset = "0x27A1CD0", VA = "0x1827A30D0")]
			public void Render(bool isZoneAccessible)
			{
			}

			// Token: 0x0602BB1D RID: 178973 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602BB1D")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Act17sideEntryCursorItem()
			{
			}

			// Token: 0x0403F377 RID: 258935
			[Token(Token = "0x403F377")]
			[FieldOffset(Offset = "0x10")]
			public string bindZoneName;

			// Token: 0x0403F378 RID: 258936
			[Token(Token = "0x403F378")]
			[FieldOffset(Offset = "0x18")]
			public TwoStateToggle cursor;

			// Token: 0x0403F379 RID: 258937
			[Token(Token = "0x403F379")]
			[FieldOffset(Offset = "0x20")]
			public float rotatePos;
		}
	}
}
