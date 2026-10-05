using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.ObjectPool;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Battle.UI.Sandbox
{
	// Token: 0x020033C2 RID: 13250
	[Token(Token = "0x20033C2")]
	public class UIBattleSandboxDeco : BattleReusableUI, UICard.IUICardPlugin, IReusableObject, IReusable, IPtrObject
	{
		// Token: 0x1700322C RID: 12844
		// (get) Token: 0x06015240 RID: 86592 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700322C")]
		public SandboxV2Data dataTable
		{
			[Token(Token = "0x6015240")]
			[Address(RVA = "0xD90970", Offset = "0xD8F570", VA = "0x180D90970")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700322D RID: 12845
		// (get) Token: 0x06015241 RID: 86593 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700322D")]
		public string pluginId
		{
			[Token(Token = "0x6015241")]
			[Address(RVA = "0xD90A00", Offset = "0xD8F600", VA = "0x180D90A00", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x06015242 RID: 86594 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015242")]
		[Address(RVA = "0xD907A0", Offset = "0xD8F3A0", VA = "0x180D907A0", Slot = "14")]
		public void OnInit(UICard uiCard)
		{
		}

		// Token: 0x06015243 RID: 86595 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015243")]
		[Address(RVA = "0xD90600", Offset = "0xD8F200", VA = "0x180D90600", Slot = "12")]
		public void OnAppearanceRefresh(UICard uiCard)
		{
		}

		// Token: 0x06015244 RID: 86596 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6015244")]
		[Address(RVA = "0xD905A0", Offset = "0xD8F1A0", VA = "0x180D905A0", Slot = "16")]
		public MonoBehaviour GetRootMono()
		{
			return null;
		}

		// Token: 0x06015245 RID: 86597 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015245")]
		[Address(RVA = "0xD908C0", Offset = "0xD8F4C0", VA = "0x180D908C0")]
		public UIBattleSandboxDeco()
		{
		}

		// Token: 0x0401935C RID: 103260
		[Token(Token = "0x401935C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _decoImg;

		// Token: 0x0401935D RID: 103261
		[Token(Token = "0x401935D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform _root;

		// Token: 0x0401935E RID: 103262
		[Token(Token = "0x401935E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private List<Sprite> _trapLevelHint;

		// Token: 0x0401935F RID: 103263
		[Token(Token = "0x401935F")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private RectTransform _defaultTransData;

		// Token: 0x04019360 RID: 103264
		[Token(Token = "0x4019360")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_dataTable;

		// Token: 0x04019361 RID: 103265
		[Token(Token = "0x4019361")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_pluginId;

		// Token: 0x04019362 RID: 103266
		[Token(Token = "0x4019362")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04019363 RID: 103267
		[Token(Token = "0x4019363")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnAppearanceRefresh;

		// Token: 0x04019364 RID: 103268
		[Token(Token = "0x4019364")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetRootMono;

		// Token: 0x04019365 RID: 103269
		[Token(Token = "0x4019365")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
