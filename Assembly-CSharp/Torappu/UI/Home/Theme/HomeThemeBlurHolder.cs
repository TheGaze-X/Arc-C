using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Home.Theme
{
	// Token: 0x02004C57 RID: 19543
	[Token(Token = "0x2004C57")]
	public class HomeThemeBlurHolder : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601D535 RID: 120117 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D535")]
		[Address(RVA = "0x16E6560", Offset = "0x16E5160", VA = "0x1816E6560")]
		public void SetBlurParam(int blurLevel, int downSample)
		{
		}

		// Token: 0x0601D536 RID: 120118 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D536")]
		[Address(RVA = "0x16E66F0", Offset = "0x16E52F0", VA = "0x1816E66F0")]
		public HomeThemeBlurHolder()
		{
		}

		// Token: 0x04026960 RID: 158048
		[Token(Token = "0x4026960")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private BlurScreenTexGenerator _blurGen;

		// Token: 0x04026961 RID: 158049
		[Token(Token = "0x4026961")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Material _blurMaterial;

		// Token: 0x04026962 RID: 158050
		[Token(Token = "0x4026962")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Tooltip("相机RT分辨率，若-1则使用屏幕分辨率")]
		private Vector2 _screenSize;

		// Token: 0x04026963 RID: 158051
		[Token(Token = "0x4026963")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Range(0f, 10f)]
		private int _downSample;

		// Token: 0x04026964 RID: 158052
		[Token(Token = "0x4026964")]
		private const string DEFAULT_BLUR_TEX_NAME = "_HGShadowMap";

		// Token: 0x04026965 RID: 158053
		[Token(Token = "0x4026965")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SetBlurParam;

		// Token: 0x04026966 RID: 158054
		[Token(Token = "0x4026966")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
