using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020036A4 RID: 13988
	[Token(Token = "0x20036A4")]
	public class CutinImageElement : CutinElement, IHotfixable
	{
		// Token: 0x060163C9 RID: 91081 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60163C9")]
		[Address(RVA = "0xEB1B50", Offset = "0xEB0750", VA = "0x180EB1B50", Slot = "4")]
		public override Tween SetCutinElement(CutinElementParam param, ILoadAsset assetLoader)
		{
			return null;
		}

		// Token: 0x060163CA RID: 91082 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60163CA")]
		[Address(RVA = "0xEB2010", Offset = "0xEB0C10", VA = "0x180EB2010")]
		private string _EnsureResPath(CutinParam.ParamType type, string spriteName)
		{
			return null;
		}

		// Token: 0x060163CB RID: 91083 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60163CB")]
		[Address(RVA = "0xEB20F0", Offset = "0xEB0CF0", VA = "0x180EB20F0")]
		private void _SetStencilComp(CutinElementParam param)
		{
		}

		// Token: 0x060163CC RID: 91084 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60163CC")]
		[Address(RVA = "0xEB1910", Offset = "0xEB0510", VA = "0x180EB1910", Slot = "5")]
		public override Tween DoMove(Vector3 fromPos, Vector3 toPos, float duration)
		{
			return null;
		}

		// Token: 0x060163CD RID: 91085 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60163CD")]
		[Address(RVA = "0xEB1A20", Offset = "0xEB0620", VA = "0x180EB1A20", Slot = "6")]
		public override Tween DoScale(Vector3 scaleFrom, Vector3 scaleTo, float duration)
		{
			return null;
		}

		// Token: 0x060163CE RID: 91086 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60163CE")]
		[Address(RVA = "0xEB1820", Offset = "0xEB0420", VA = "0x180EB1820")]
		public void ClearElement()
		{
		}

		// Token: 0x060163CF RID: 91087 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60163CF")]
		[Address(RVA = "0xEB2180", Offset = "0xEB0D80", VA = "0x180EB2180")]
		public CutinImageElement()
		{
		}

		// Token: 0x0401ABC2 RID: 109506
		[Token(Token = "0x401ABC2")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform _offset;

		// Token: 0x0401ABC3 RID: 109507
		[Token(Token = "0x401ABC3")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _img;

		// Token: 0x0401ABC4 RID: 109508
		[Token(Token = "0x401ABC4")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIStencilComponent _stencilComp;

		// Token: 0x0401ABC5 RID: 109509
		[Token(Token = "0x401ABC5")]
		private const float DEFAULT_FADE_DURATION = 0.13f;

		// Token: 0x0401ABC6 RID: 109510
		[Token(Token = "0x401ABC6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SetCutinElement;

		// Token: 0x0401ABC7 RID: 109511
		[Token(Token = "0x401ABC7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__EnsureResPath;

		// Token: 0x0401ABC8 RID: 109512
		[Token(Token = "0x401ABC8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__SetStencilComp;

		// Token: 0x0401ABC9 RID: 109513
		[Token(Token = "0x401ABC9")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_DoMove;

		// Token: 0x0401ABCA RID: 109514
		[Token(Token = "0x401ABCA")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_DoScale;

		// Token: 0x0401ABCB RID: 109515
		[Token(Token = "0x401ABCB")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_ClearElement;

		// Token: 0x0401ABCC RID: 109516
		[Token(Token = "0x401ABCC")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
