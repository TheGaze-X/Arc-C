using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020036A3 RID: 13987
	[Token(Token = "0x20036A3")]
	public abstract class CutinElement : MonoBehaviour, IHotfixable
	{
		// Token: 0x060163C5 RID: 91077
		[Token(Token = "0x60163C5")]
		public abstract Tween SetCutinElement(CutinElementParam param, ILoadAsset assetLoader);

		// Token: 0x060163C6 RID: 91078
		[Token(Token = "0x60163C6")]
		public abstract Tween DoMove(Vector3 fromPos, Vector3 toPos, float duration);

		// Token: 0x060163C7 RID: 91079
		[Token(Token = "0x60163C7")]
		public abstract Tween DoScale(Vector3 scaleFrom, Vector3 scaleTo, float duration);

		// Token: 0x060163C8 RID: 91080 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60163C8")]
		[Address(RVA = "0xEB17C0", Offset = "0xEB03C0", VA = "0x180EB17C0")]
		protected CutinElement()
		{
		}

		// Token: 0x0401ABC1 RID: 109505
		[Token(Token = "0x401ABC1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
