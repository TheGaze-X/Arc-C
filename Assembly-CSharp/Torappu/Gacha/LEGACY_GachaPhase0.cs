using System;
using System.Collections;
using AdvancedInspector;
using Il2CppDummyDll;
using Spine.Unity;
using UnityEngine;
using XLua;

namespace Torappu.Gacha
{
	// Token: 0x02001678 RID: 5752
	[Token(Token = "0x2001678")]
	public class LEGACY_GachaPhase0 : GachaController.GachaPhase
	{
		// Token: 0x17000F84 RID: 3972
		// (get) Token: 0x06008279 RID: 33401 RVA: 0x00038D18 File Offset: 0x00036F18
		[Token(Token = "0x17000F84")]
		public override bool canSkip
		{
			[Token(Token = "0x6008279")]
			[Address(RVA = "0x2B08B70", Offset = "0x2B07770", VA = "0x182B08B70", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600827A RID: 33402 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600827A")]
		[Address(RVA = "0x2B08830", Offset = "0x2B07430", VA = "0x182B08830", Slot = "6")]
		public override IEnumerator Play(GachaController controller, GachaController.PlayMode playMode)
		{
			return null;
		}

		// Token: 0x0600827B RID: 33403 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600827B")]
		[Address(RVA = "0x2B089F0", Offset = "0x2B075F0", VA = "0x182B089F0", Slot = "7")]
		public override void SkipToEnd(GachaController controller, GachaController.PlayMode playMode)
		{
		}

		// Token: 0x0600827C RID: 33404 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600827C")]
		[Address(RVA = "0x2B08910", Offset = "0x2B07510", VA = "0x182B08910", Slot = "9")]
		public override void PreloadSounds(GachaController.PlayMode playMode, RarityRank rarity, bool isMultipleGacha)
		{
		}

		// Token: 0x0600827D RID: 33405 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600827D")]
		[Address(RVA = "0x2B08A90", Offset = "0x2B07690", VA = "0x182B08A90")]
		public LEGACY_GachaPhase0()
		{
		}

		// Token: 0x040084B5 RID: 33973
		[Token(Token = "0x40084B5")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float _earlyExitTime;

		// Token: 0x040084B6 RID: 33974
		[Token(Token = "0x40084B6")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float _delayToDisable;

		// Token: 0x040084B7 RID: 33975
		[Token(Token = "0x40084B7")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SkeletonGraphic _skeleton;

		// Token: 0x040084B8 RID: 33976
		[Token(Token = "0x40084B8")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Collection(typeof(RarityRank))]
		private string[] _animations;

		// Token: 0x040084B9 RID: 33977
		[Token(Token = "0x40084B9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_canSkip;

		// Token: 0x040084BA RID: 33978
		[Token(Token = "0x40084BA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Play;

		// Token: 0x040084BB RID: 33979
		[Token(Token = "0x40084BB")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SkipToEnd;

		// Token: 0x040084BC RID: 33980
		[Token(Token = "0x40084BC")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_PreloadSounds;

		// Token: 0x040084BD RID: 33981
		[Token(Token = "0x40084BD")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
