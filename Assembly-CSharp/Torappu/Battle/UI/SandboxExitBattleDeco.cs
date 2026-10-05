using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle.GameMode;
using Torappu.UI.SandboxPerm.SandboxV2;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Battle.UI
{
	// Token: 0x02003316 RID: 13078
	[Token(Token = "0x2003316")]
	public class SandboxExitBattleDeco : SandboxV2ConfirmDialogDecoViewBase
	{
		// Token: 0x1700312E RID: 12590
		// (get) Token: 0x06014C69 RID: 85097 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700312E")]
		private GameModeFactory.SandboxGameMode gamemode
		{
			[Token(Token = "0x6014C69")]
			[Address(RVA = "0xD347D0", Offset = "0xD333D0", VA = "0x180D347D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700312F RID: 12591
		// (get) Token: 0x06014C6A RID: 85098 RVA: 0x000884B8 File Offset: 0x000866B8
		[Token(Token = "0x1700312F")]
		private SandboxV2NodeType nodeType
		{
			[Token(Token = "0x6014C6A")]
			[Address(RVA = "0xD34850", Offset = "0xD33450", VA = "0x180D34850")]
			get
			{
				return SandboxV2NodeType.NONE;
			}
		}

		// Token: 0x06014C6B RID: 85099 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014C6B")]
		[Address(RVA = "0xD32C00", Offset = "0xD31800", VA = "0x180D32C00")]
		private void Awake()
		{
		}

		// Token: 0x06014C6C RID: 85100 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014C6C")]
		[Address(RVA = "0xD32F20", Offset = "0xD31B20", VA = "0x180D32F20")]
		public void _DoRender()
		{
		}

		// Token: 0x06014C6D RID: 85101 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014C6D")]
		[Address(RVA = "0xD330A0", Offset = "0xD31CA0", VA = "0x180D330A0")]
		private void _InitDefault()
		{
		}

		// Token: 0x06014C6E RID: 85102 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014C6E")]
		[Address(RVA = "0xD331B0", Offset = "0xD31DB0", VA = "0x180D331B0")]
		private void _SetUIVisible()
		{
		}

		// Token: 0x06014C6F RID: 85103 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014C6F")]
		[Address(RVA = "0xD33BB0", Offset = "0xD327B0", VA = "0x180D33BB0")]
		private void _ShowHome()
		{
		}

		// Token: 0x06014C70 RID: 85104 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014C70")]
		[Address(RVA = "0xD33ED0", Offset = "0xD32AD0", VA = "0x180D33ED0")]
		private void _ShowMine()
		{
		}

		// Token: 0x06014C71 RID: 85105 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014C71")]
		[Address(RVA = "0xD338E0", Offset = "0xD324E0", VA = "0x180D338E0")]
		private void _ShowGate()
		{
		}

		// Token: 0x06014C72 RID: 85106 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014C72")]
		[Address(RVA = "0xD341A0", Offset = "0xD32DA0", VA = "0x180D341A0")]
		private void _ShowNest()
		{
		}

		// Token: 0x06014C73 RID: 85107 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014C73")]
		[Address(RVA = "0xD33610", Offset = "0xD32210", VA = "0x180D33610")]
		private void _ShowCave()
		{
		}

		// Token: 0x06014C74 RID: 85108 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014C74")]
		[Address(RVA = "0xD344A0", Offset = "0xD330A0", VA = "0x180D344A0")]
		private void _ShowRushOrBattle()
		{
		}

		// Token: 0x06014C75 RID: 85109 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014C75")]
		[Address(RVA = "0xD32D40", Offset = "0xD31940", VA = "0x180D32D40", Slot = "4")]
		public override void RenderDecoView(object param)
		{
		}

		// Token: 0x06014C76 RID: 85110 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014C76")]
		[Address(RVA = "0xD34770", Offset = "0xD33370", VA = "0x180D34770")]
		public SandboxExitBattleDeco()
		{
		}

		// Token: 0x04018B76 RID: 101238
		[Token(Token = "0x4018B76")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform _root;

		// Token: 0x04018B77 RID: 101239
		[Token(Token = "0x4018B77")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _iconImage;

		// Token: 0x04018B78 RID: 101240
		[Token(Token = "0x4018B78")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _rushText;

		// Token: 0x04018B79 RID: 101241
		[Token(Token = "0x4018B79")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _rushRatioText;

		// Token: 0x04018B7A RID: 101242
		[Token(Token = "0x4018B7A")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _stageText;

		// Token: 0x04018B7B RID: 101243
		[Token(Token = "0x4018B7B")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _hintLabel;

		// Token: 0x04018B7C RID: 101244
		[Token(Token = "0x4018B7C")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Transform _lifeRatioRoot;

		// Token: 0x04018B7D RID: 101245
		[Token(Token = "0x4018B7D")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Transform _lifeRatioHomeRoot;

		// Token: 0x04018B7E RID: 101246
		[Token(Token = "0x4018B7E")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Transform _fillImageRoot;

		// Token: 0x04018B7F RID: 101247
		[Token(Token = "0x4018B7F")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Image _fillImage;

		// Token: 0x04018B80 RID: 101248
		[Token(Token = "0x4018B80")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Text _lifeRatioText;

		// Token: 0x04018B81 RID: 101249
		[Token(Token = "0x4018B81")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Text _lifeRatioTextHome;

		// Token: 0x04018B82 RID: 101250
		[Token(Token = "0x4018B82")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Color _homeColorYellow;

		// Token: 0x04018B83 RID: 101251
		[Token(Token = "0x4018B83")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Color _bossColorRed;

		// Token: 0x04018B84 RID: 101252
		[Token(Token = "0x4018B84")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Color _defaultColorWhite;

		// Token: 0x04018B85 RID: 101253
		[Token(Token = "0x4018B85")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private List<SandboxExitBattleDeco.NodeTypeIconRef> _nodeTypeIconRef;

		// Token: 0x04018B86 RID: 101254
		[Token(Token = "0x4018B86")]
		private const string RUSH_RATIO_FORMAT = "{0}/{1}";

		// Token: 0x04018B87 RID: 101255
		[Token(Token = "0x4018B87")]
		private const string LIFE_RATIO_FORMAT = "{0}%";

		// Token: 0x04018B88 RID: 101256
		[Token(Token = "0x4018B88")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_gamemode;

		// Token: 0x04018B89 RID: 101257
		[Token(Token = "0x4018B89")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_nodeType;

		// Token: 0x04018B8A RID: 101258
		[Token(Token = "0x4018B8A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Awake;

		// Token: 0x04018B8B RID: 101259
		[Token(Token = "0x4018B8B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__DoRender;

		// Token: 0x04018B8C RID: 101260
		[Token(Token = "0x4018B8C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InitDefault;

		// Token: 0x04018B8D RID: 101261
		[Token(Token = "0x4018B8D")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__SetUIVisible;

		// Token: 0x04018B8E RID: 101262
		[Token(Token = "0x4018B8E")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__ShowHome;

		// Token: 0x04018B8F RID: 101263
		[Token(Token = "0x4018B8F")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__ShowMine;

		// Token: 0x04018B90 RID: 101264
		[Token(Token = "0x4018B90")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__ShowGate;

		// Token: 0x04018B91 RID: 101265
		[Token(Token = "0x4018B91")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__ShowNest;

		// Token: 0x04018B92 RID: 101266
		[Token(Token = "0x4018B92")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__ShowCave;

		// Token: 0x04018B93 RID: 101267
		[Token(Token = "0x4018B93")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__ShowRushOrBattle;

		// Token: 0x04018B94 RID: 101268
		[Token(Token = "0x4018B94")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_RenderDecoView;

		// Token: 0x04018B95 RID: 101269
		[Token(Token = "0x4018B95")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003317 RID: 13079
		[Token(Token = "0x2003317")]
		[Serializable]
		private class NodeTypeIconRef : IHotfixable
		{
			// Token: 0x06014C77 RID: 85111 RVA: 0x000884D0 File Offset: 0x000866D0
			[Token(Token = "0x6014C77")]
			[Address(RVA = "0xD32AE0", Offset = "0xD316E0", VA = "0x180D32AE0")]
			public bool Valid(SandboxV2NodeType type, bool isRush)
			{
				return default(bool);
			}

			// Token: 0x06014C78 RID: 85112 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6014C78")]
			[Address(RVA = "0xD32BA0", Offset = "0xD317A0", VA = "0x180D32BA0")]
			public NodeTypeIconRef()
			{
			}

			// Token: 0x04018B96 RID: 101270
			[Token(Token = "0x4018B96")]
			[FieldOffset(Offset = "0x10")]
			public SandboxV2NodeType type;

			// Token: 0x04018B97 RID: 101271
			[Token(Token = "0x4018B97")]
			[FieldOffset(Offset = "0x14")]
			public bool isRush;

			// Token: 0x04018B98 RID: 101272
			[Token(Token = "0x4018B98")]
			[FieldOffset(Offset = "0x18")]
			public Sprite sprite;

			// Token: 0x04018B99 RID: 101273
			[Token(Token = "0x4018B99")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_Valid;

			// Token: 0x04018B9A RID: 101274
			[Token(Token = "0x4018B9A")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
