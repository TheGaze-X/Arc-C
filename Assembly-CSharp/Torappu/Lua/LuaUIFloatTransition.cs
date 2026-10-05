using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Lua
{
	// Token: 0x02001617 RID: 5655
	[Token(Token = "0x2001617")]
	internal class LuaUIFloatTransition : LuaUITransEffect
	{
		// Token: 0x06008072 RID: 32882 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6008072")]
		[Address(RVA = "0x2892320", Offset = "0x2890F20", VA = "0x182892320", Slot = "4")]
		public override IEnumerator ShowCoroutine()
		{
			return null;
		}

		// Token: 0x06008073 RID: 32883 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008073")]
		[Address(RVA = "0x28925F0", Offset = "0x28911F0", VA = "0x1828925F0")]
		private void _SetupBlurShot()
		{
		}

		// Token: 0x06008074 RID: 32884 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6008074")]
		[Address(RVA = "0x28921F0", Offset = "0x2890DF0", VA = "0x1828921F0", Slot = "5")]
		public override IEnumerator HideCoroutine()
		{
			return null;
		}

		// Token: 0x06008075 RID: 32885 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008075")]
		[Address(RVA = "0x2892470", Offset = "0x2891070", VA = "0x182892470")]
		private void _CleanBlurShot()
		{
		}

		// Token: 0x06008076 RID: 32886 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008076")]
		[Address(RVA = "0x28923D0", Offset = "0x2890FD0", VA = "0x1828923D0", Slot = "6")]
		public override void ShowImmediatly()
		{
		}

		// Token: 0x06008077 RID: 32887 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008077")]
		[Address(RVA = "0x28922A0", Offset = "0x2890EA0", VA = "0x1828922A0", Slot = "7")]
		public override void HideImmediatly()
		{
		}

		// Token: 0x06008078 RID: 32888 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008078")]
		[Address(RVA = "0x2892900", Offset = "0x2891500", VA = "0x182892900")]
		public LuaUIFloatTransition()
		{
		}

		// Token: 0x04008193 RID: 33171
		[Token(Token = "0x4008193")]
		public const float FADE_DURATION = 0.23f;

		// Token: 0x04008194 RID: 33172
		[Token(Token = "0x4008194")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Tooltip("Nullable.The background to show blurred parent view")]
		private UIFullScreenImage _background;

		// Token: 0x04008195 RID: 33173
		[Token(Token = "0x4008195")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Tooltip("The root view of the popup state")]
		private CanvasGroup _rootView;

		// Token: 0x04008196 RID: 33174
		[Token(Token = "0x4008196")]
		[FieldOffset(Offset = "0x28")]
		private List<Camera> m_cameraCache;

		// Token: 0x04008197 RID: 33175
		[Token(Token = "0x4008197")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ShowCoroutine;

		// Token: 0x04008198 RID: 33176
		[Token(Token = "0x4008198")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__SetupBlurShot;

		// Token: 0x04008199 RID: 33177
		[Token(Token = "0x4008199")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_HideCoroutine;

		// Token: 0x0400819A RID: 33178
		[Token(Token = "0x400819A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__CleanBlurShot;

		// Token: 0x0400819B RID: 33179
		[Token(Token = "0x400819B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_ShowImmediatly;

		// Token: 0x0400819C RID: 33180
		[Token(Token = "0x400819C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_HideImmediatly;

		// Token: 0x0400819D RID: 33181
		[Token(Token = "0x400819D")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
