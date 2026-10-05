using System;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.AVG;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003697 RID: 13975
	[Token(Token = "0x2003697")]
	public class CutinAVGCharacterSlot : CutinElement
	{
		// Token: 0x0601639D RID: 91037 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601639D")]
		[Address(RVA = "0xEAE5F0", Offset = "0xEAD1F0", VA = "0x180EAE5F0", Slot = "5")]
		public override Tween DoMove(Vector3 fromPos, Vector3 toPos, float duration)
		{
			return null;
		}

		// Token: 0x0601639E RID: 91038 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601639E")]
		[Address(RVA = "0xEAE700", Offset = "0xEAD300", VA = "0x180EAE700", Slot = "6")]
		public override Tween DoScale(Vector3 scaleFrom, Vector3 scaleTo, float duration)
		{
			return null;
		}

		// Token: 0x0601639F RID: 91039 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601639F")]
		[Address(RVA = "0xEAE830", Offset = "0xEAD430", VA = "0x180EAE830", Slot = "4")]
		public override Tween SetCutinElement(CutinElementParam param, ILoadAsset assetLoader)
		{
			return null;
		}

		// Token: 0x060163A0 RID: 91040 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60163A0")]
		[Address(RVA = "0xEAEA80", Offset = "0xEAD680", VA = "0x180EAEA80")]
		private void _SetStencilComp(CutinElementParam param)
		{
		}

		// Token: 0x060163A1 RID: 91041 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60163A1")]
		[Address(RVA = "0xEAEB20", Offset = "0xEAD720", VA = "0x180EAEB20")]
		public CutinAVGCharacterSlot()
		{
		}

		// Token: 0x0401AB45 RID: 109381
		[Token(Token = "0x401AB45")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private AVGCharacterSlot _charslot;

		// Token: 0x0401AB46 RID: 109382
		[Token(Token = "0x401AB46")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIStencilComponent _foreImgStencilComponent;

		// Token: 0x0401AB47 RID: 109383
		[Token(Token = "0x401AB47")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIStencilComponent _backImgStencilComponent;

		// Token: 0x0401AB48 RID: 109384
		[Token(Token = "0x401AB48")]
		[FieldOffset(Offset = "0x30")]
		private string m_cachedChar;

		// Token: 0x0401AB49 RID: 109385
		[Token(Token = "0x401AB49")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_DoMove;

		// Token: 0x0401AB4A RID: 109386
		[Token(Token = "0x401AB4A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_DoScale;

		// Token: 0x0401AB4B RID: 109387
		[Token(Token = "0x401AB4B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SetCutinElement;

		// Token: 0x0401AB4C RID: 109388
		[Token(Token = "0x401AB4C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__SetStencilComp;

		// Token: 0x0401AB4D RID: 109389
		[Token(Token = "0x401AB4D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
