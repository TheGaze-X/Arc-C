using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.UI
{
	// Token: 0x020036DF RID: 14047
	[Token(Token = "0x20036DF")]
	[Serializable]
	public class UIAnimation
	{
		// Token: 0x170035A0 RID: 13728
		// (get) Token: 0x0601650A RID: 91402 RVA: 0x00090828 File Offset: 0x0008EA28
		[Token(Token = "0x170035A0")]
		[Inspect(Level = 2)]
		public bool isPlaying
		{
			[Token(Token = "0x601650A")]
			[Address(RVA = "0xECE7F0", Offset = "0xECD3F0", VA = "0x180ECE7F0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0601650B RID: 91403 RVA: 0x00090840 File Offset: 0x0008EA40
		[Token(Token = "0x601650B")]
		[Address(RVA = "0xECE680", Offset = "0xECD280", VA = "0x180ECE680")]
		public bool Play(AnimationOptions option)
		{
			return default(bool);
		}

		// Token: 0x0601650C RID: 91404 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601650C")]
		[Address(RVA = "0xECE700", Offset = "0xECD300", VA = "0x180ECE700")]
		public void Stop(bool isTriggerEnd)
		{
		}

		// Token: 0x0601650D RID: 91405 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601650D")]
		[Address(RVA = "0xECE560", Offset = "0xECD160", VA = "0x180ECE560")]
		public void ClipToEnd()
		{
		}

		// Token: 0x0601650E RID: 91406 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601650E")]
		[Address(RVA = "0xECE5F0", Offset = "0xECD1F0", VA = "0x180ECE5F0")]
		public void ClipToStart()
		{
		}

		// Token: 0x170035A1 RID: 13729
		// (get) Token: 0x0601650F RID: 91407 RVA: 0x00090858 File Offset: 0x0008EA58
		[Token(Token = "0x170035A1")]
		public float Length
		{
			[Token(Token = "0x601650F")]
			[Address(RVA = "0xECE760", Offset = "0xECD360", VA = "0x180ECE760")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x06016510 RID: 91408 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016510")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public UIAnimation()
		{
		}

		// Token: 0x0401AD6E RID: 109934
		[Token(Token = "0x401AD6E")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private UIAnimationLocation _location;

		// Token: 0x0401AD6F RID: 109935
		[Token(Token = "0x401AD6F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool _isPlayInverse;
	}
}
