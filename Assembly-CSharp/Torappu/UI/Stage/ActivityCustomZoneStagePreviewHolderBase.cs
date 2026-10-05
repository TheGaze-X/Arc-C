using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x020068DE RID: 26846
	[Token(Token = "0x20068DE")]
	public abstract class ActivityCustomZoneStagePreviewHolderBase : DataBinder<ActivityCustomZoneMapProperty>
	{
		// Token: 0x06026760 RID: 157536 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026760")]
		[Address(RVA = "0x2177BB0", Offset = "0x21767B0", VA = "0x182177BB0", Slot = "7")]
		public override void OnValueChanged(ActivityCustomZoneMapProperty property)
		{
		}

		// Token: 0x06026761 RID: 157537 RVA: 0x000CB388 File Offset: 0x000C9588
		[Token(Token = "0x6026761")]
		[Address(RVA = "0x2177EA0", Offset = "0x2176AA0", VA = "0x182177EA0")]
		private bool _TryLoadStagePreview(string prefabPath)
		{
			return default(bool);
		}

		// Token: 0x06026762 RID: 157538 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026762")]
		[Address(RVA = "0x2177D20", Offset = "0x2176920", VA = "0x182177D20")]
		private void _ClearLoadedStagePreview()
		{
		}

		// Token: 0x06026763 RID: 157539 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026763")]
		[Address(RVA = "0x2177DA0", Offset = "0x21769A0", VA = "0x182177DA0")]
		private StagePreviewEventHolder _GenEventHolder()
		{
			return null;
		}

		// Token: 0x06026764 RID: 157540 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026764")]
		[Address(RVA = "0x2177CC0", Offset = "0x21768C0", VA = "0x182177CC0", Slot = "8")]
		protected virtual void StartBattle()
		{
		}

		// Token: 0x06026765 RID: 157541 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026765")]
		[Address(RVA = "0x2178180", Offset = "0x2176D80", VA = "0x182178180")]
		protected ActivityCustomZoneStagePreviewHolderBase()
		{
		}

		// Token: 0x040362F8 RID: 221944
		[Token(Token = "0x40362F8")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _stagePreviewContainer;

		// Token: 0x040362F9 RID: 221945
		[Token(Token = "0x40362F9")]
		[FieldOffset(Offset = "0x28")]
		private string m_stagePreviewPathCache;

		// Token: 0x040362FA RID: 221946
		[Token(Token = "0x40362FA")]
		[FieldOffset(Offset = "0x30")]
		private StagePreviewInfoBasicPanel m_stagePreview;

		// Token: 0x040362FB RID: 221947
		[Token(Token = "0x40362FB")]
		[FieldOffset(Offset = "0x38")]
		private UIPageFinder m_pageFinder;

		// Token: 0x040362FC RID: 221948
		[Token(Token = "0x40362FC")]
		[FieldOffset(Offset = "0x48")]
		protected ActivityCustomZoneMapViewModel m_cachedZoneMapModel;

		// Token: 0x040362FD RID: 221949
		[Token(Token = "0x40362FD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x040362FE RID: 221950
		[Token(Token = "0x40362FE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__TryLoadStagePreview;

		// Token: 0x040362FF RID: 221951
		[Token(Token = "0x40362FF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__ClearLoadedStagePreview;

		// Token: 0x04036300 RID: 221952
		[Token(Token = "0x4036300")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__GenEventHolder;

		// Token: 0x04036301 RID: 221953
		[Token(Token = "0x4036301")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_StartBattle;

		// Token: 0x04036302 RID: 221954
		[Token(Token = "0x4036302")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
