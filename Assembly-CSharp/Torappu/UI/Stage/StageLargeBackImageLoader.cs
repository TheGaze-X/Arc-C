using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x02006801 RID: 26625
	[Token(Token = "0x2006801")]
	public class StageLargeBackImageLoader : PageAssetPool<Sprite>
	{
		// Token: 0x06026276 RID: 156278 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026276")]
		[Address(RVA = "0x213BC70", Offset = "0x213A870", VA = "0x18213BC70")]
		public static Sprite LoadAutoPackSprite(string spriteId, string hubPath)
		{
			return null;
		}

		// Token: 0x06026277 RID: 156279 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026277")]
		[Address(RVA = "0x213BDE0", Offset = "0x213A9E0", VA = "0x18213BDE0")]
		public Sprite LoadSpriteFromHub(string spriteId, string hubPath)
		{
			return null;
		}

		// Token: 0x06026278 RID: 156280 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026278")]
		[Address(RVA = "0x213BE80", Offset = "0x213AA80", VA = "0x18213BE80")]
		private Sprite _LoadAutoPackSprite(string spriteId, string hubPath)
		{
			return null;
		}

		// Token: 0x06026279 RID: 156281 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026279")]
		[Address(RVA = "0x213C0F0", Offset = "0x213ACF0", VA = "0x18213C0F0")]
		private Sprite _LoadSpriteFromAutoPackHubByPage(string spriteId, string hubPath)
		{
			return null;
		}

		// Token: 0x0602627A RID: 156282 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602627A")]
		[Address(RVA = "0x213C270", Offset = "0x213AE70", VA = "0x18213C270")]
		public StageLargeBackImageLoader()
		{
		}

		// Token: 0x04035BCD RID: 220109
		[Token(Token = "0x4035BCD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadAutoPackSprite;

		// Token: 0x04035BCE RID: 220110
		[Token(Token = "0x4035BCE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadSpriteFromHub;

		// Token: 0x04035BCF RID: 220111
		[Token(Token = "0x4035BCF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__LoadAutoPackSprite;

		// Token: 0x04035BD0 RID: 220112
		[Token(Token = "0x4035BD0")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__LoadSpriteFromAutoPackHubByPage;

		// Token: 0x04035BD1 RID: 220113
		[Token(Token = "0x4035BD1")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
