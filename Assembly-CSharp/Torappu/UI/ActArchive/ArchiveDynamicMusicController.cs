using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006BA9 RID: 27561
	[Token(Token = "0x2006BA9")]
	public class ArchiveDynamicMusicController : ActArchiveController
	{
		// Token: 0x060275BB RID: 161211 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60275BB")]
		[Address(RVA = "0x227CAC0", Offset = "0x227B6C0", VA = "0x18227CAC0", Slot = "9")]
		public override void OnItemClick(string funcId)
		{
		}

		// Token: 0x060275BC RID: 161212 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60275BC")]
		[Address(RVA = "0x227CB60", Offset = "0x227B760", VA = "0x18227CB60")]
		public void OnSetHomeTheme()
		{
		}

		// Token: 0x060275BD RID: 161213 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60275BD")]
		[Address(RVA = "0x227C820", Offset = "0x227B420", VA = "0x18227C820")]
		public List<DataBinder<MusicProperty>> InitAndAchieveDataBinders()
		{
			return null;
		}

		// Token: 0x060275BE RID: 161214 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60275BE")]
		[Address(RVA = "0x227C900", Offset = "0x227B500", VA = "0x18227C900", Slot = "4")]
		public override void Init(ActArchiveProxy proxy)
		{
		}

		// Token: 0x060275BF RID: 161215 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60275BF")]
		[Address(RVA = "0x227C9C0", Offset = "0x227B5C0", VA = "0x18227C9C0", Slot = "5")]
		public override void OnEnter()
		{
		}

		// Token: 0x060275C0 RID: 161216 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60275C0")]
		[Address(RVA = "0x227CA40", Offset = "0x227B640", VA = "0x18227CA40", Slot = "6")]
		public override void OnExit()
		{
		}

		// Token: 0x060275C1 RID: 161217 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60275C1")]
		[Address(RVA = "0x227CBD0", Offset = "0x227B7D0", VA = "0x18227CBD0", Slot = "7")]
		public override IEnumerator Show(bool fastMode)
		{
			return null;
		}

		// Token: 0x060275C2 RID: 161218 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60275C2")]
		[Address(RVA = "0x227CCA0", Offset = "0x227B8A0", VA = "0x18227CCA0")]
		public ArchiveDynamicMusicController()
		{
		}

		// Token: 0x060275C3 RID: 161219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60275C3")]
		[Address(RVA = "0x2263DC0", Offset = "0x22629C0", VA = "0x182263DC0")]
		private void <>xLuaBaseProxy_OnItemClick(string P0)
		{
		}

		// Token: 0x060275C4 RID: 161220 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60275C4")]
		[Address(RVA = "0x2252DF0", Offset = "0x22519F0", VA = "0x182252DF0")]
		private void <>xLuaBaseProxy_Init(ActArchiveProxy P0)
		{
		}

		// Token: 0x060275C5 RID: 161221 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60275C5")]
		[Address(RVA = "0x2252E00", Offset = "0x2251A00", VA = "0x182252E00")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x060275C6 RID: 161222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60275C6")]
		[Address(RVA = "0x2252E10", Offset = "0x2251A10", VA = "0x182252E10")]
		private void <>xLuaBaseProxy_OnExit()
		{
		}

		// Token: 0x060275C7 RID: 161223 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60275C7")]
		[Address(RVA = "0x227CC90", Offset = "0x227B890", VA = "0x18227CC90")]
		private IEnumerator <>xLuaBaseProxy_Show(bool P0)
		{
			return null;
		}

		// Token: 0x04037C2F RID: 228399
		[Token(Token = "0x4037C2F")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private ArchiveMusicListDataBinder _musicListBinder;

		// Token: 0x04037C30 RID: 228400
		[Token(Token = "0x4037C30")]
		[FieldOffset(Offset = "0x40")]
		[NonSerialized]
		public Action<ActArchiveType, string> onMusicItemClicked;

		// Token: 0x04037C31 RID: 228401
		[Token(Token = "0x4037C31")]
		[FieldOffset(Offset = "0x48")]
		[NonSerialized]
		public Action onSetHomeTheme;

		// Token: 0x04037C32 RID: 228402
		[Token(Token = "0x4037C32")]
		[FieldOffset(Offset = "0x50")]
		private ArchiveDynamicMusicController.Handler m_handler;

		// Token: 0x04037C33 RID: 228403
		[Token(Token = "0x4037C33")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnItemClick;

		// Token: 0x04037C34 RID: 228404
		[Token(Token = "0x4037C34")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnSetHomeTheme;

		// Token: 0x04037C35 RID: 228405
		[Token(Token = "0x4037C35")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_InitAndAchieveDataBinders;

		// Token: 0x04037C36 RID: 228406
		[Token(Token = "0x4037C36")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04037C37 RID: 228407
		[Token(Token = "0x4037C37")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04037C38 RID: 228408
		[Token(Token = "0x4037C38")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnExit;

		// Token: 0x04037C39 RID: 228409
		[Token(Token = "0x4037C39")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_Show;

		// Token: 0x04037C3A RID: 228410
		[Token(Token = "0x4037C3A")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006BAA RID: 27562
		[Token(Token = "0x2006BAA")]
		private class Handler : ArchiveMusicControllerHandler
		{
			// Token: 0x060275C8 RID: 161224 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60275C8")]
			[Address(RVA = "0x22A1FF0", Offset = "0x22A0BF0", VA = "0x1822A1FF0")]
			public Handler(ArchiveDynamicMusicController closure)
			{
			}

			// Token: 0x060275C9 RID: 161225 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60275C9")]
			[Address(RVA = "0x22A1F50", Offset = "0x22A0B50", VA = "0x1822A1F50", Slot = "4")]
			public override void OnItemClick(string funcId)
			{
			}

			// Token: 0x04037C3B RID: 228411
			[Token(Token = "0x4037C3B")]
			[FieldOffset(Offset = "0x10")]
			private ArchiveDynamicMusicController m_closure;

			// Token: 0x04037C3C RID: 228412
			[Token(Token = "0x4037C3C")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04037C3D RID: 228413
			[Token(Token = "0x4037C3D")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnItemClick;
		}
	}
}
