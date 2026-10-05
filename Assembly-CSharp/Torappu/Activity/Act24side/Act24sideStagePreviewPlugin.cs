using System;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.Stage;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act24side
{
	// Token: 0x02007615 RID: 30229
	[Token(Token = "0x2007615")]
	public class Act24sideStagePreviewPlugin : StagePreviewActPlugin
	{
		// Token: 0x0602A8EC RID: 174316 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A8EC")]
		[Address(RVA = "0x2661D40", Offset = "0x2660940", VA = "0x182661D40", Slot = "4")]
		public override Sprite LoadMapPreview(string actId, string stageId, ILoadAsset assetLoader)
		{
			return null;
		}

		// Token: 0x0602A8ED RID: 174317 RVA: 0x000D8F90 File Offset: 0x000D7190
		[Token(Token = "0x602A8ED")]
		[Address(RVA = "0x26620D0", Offset = "0x2660CD0", VA = "0x1826620D0", Slot = "5")]
		public override bool TryGetRewardDetailBgTint(string actId, string stageId, out Color bgTint)
		{
			return default(bool);
		}

		// Token: 0x0602A8EE RID: 174318 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A8EE")]
		[Address(RVA = "0x2662180", Offset = "0x2660D80", VA = "0x182662180")]
		public Act24sideStagePreviewPlugin()
		{
		}

		// Token: 0x0602A8EF RID: 174319 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A8EF")]
		[Address(RVA = "0x2662160", Offset = "0x2660D60", VA = "0x182662160")]
		private Sprite <>xLuaBaseProxy_LoadMapPreview(string P0, string P1, ILoadAsset P2)
		{
			return null;
		}

		// Token: 0x0602A8F0 RID: 174320 RVA: 0x000D8FA8 File Offset: 0x000D71A8
		[Token(Token = "0x602A8F0")]
		[Address(RVA = "0x2662170", Offset = "0x2660D70", VA = "0x182662170")]
		private bool <>xLuaBaseProxy_TryGetRewardDetailBgTint(string P0, string P1, out Color P2)
		{
			return default(bool);
		}

		// Token: 0x0403D455 RID: 250965
		[Token(Token = "0x403D455")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Color _rewardDetailBgTint;

		// Token: 0x0403D456 RID: 250966
		[Token(Token = "0x403D456")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadMapPreview;

		// Token: 0x0403D457 RID: 250967
		[Token(Token = "0x403D457")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_TryGetRewardDetailBgTint;

		// Token: 0x0403D458 RID: 250968
		[Token(Token = "0x403D458")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
