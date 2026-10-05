using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Colorful
{
	// Token: 0x02007D02 RID: 32002
	[Token(Token = "0x2007D02")]
	[HelpURL("http://www.thomashourdel.com/colorful/doc/camera-effects/rgb-split.html")]
	[ExecuteInEditMode]
	[AddComponentMenu("Colorful FX/Camera Effects/RGB Split")]
	public class RGBSplit : BaseEffect
	{
		// Token: 0x0602CA45 RID: 182853 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602CA45")]
		[Address(RVA = "0x2881900", Offset = "0x2880500", VA = "0x182881900", Slot = "6")]
		protected override void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		// Token: 0x0602CA46 RID: 182854 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602CA46")]
		[Address(RVA = "0x28818D0", Offset = "0x28804D0", VA = "0x1828818D0", Slot = "7")]
		protected override string GetShaderName()
		{
			return null;
		}

		// Token: 0x0602CA47 RID: 182855 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602CA47")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public RGBSplit()
		{
		}

		// Token: 0x0404052D RID: 263469
		[Token(Token = "0x404052D")]
		[FieldOffset(Offset = "0x28")]
		[Tooltip("RGB shifting amount.")]
		public float Amount;

		// Token: 0x0404052E RID: 263470
		[Token(Token = "0x404052E")]
		[FieldOffset(Offset = "0x2C")]
		[Tooltip("Shift direction in radians.")]
		public float Angle;
	}
}
