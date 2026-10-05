using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.RoguelikeTopic
{
	// Token: 0x020044FF RID: 17663
	[Token(Token = "0x20044FF")]
	public class RoguelikeCommonOuterBuffLine : MonoBehaviour, IHotfixable
	{
		// Token: 0x17003FFE RID: 16382
		// (get) Token: 0x0601AF49 RID: 110409 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003FFE")]
		public string toBuffId
		{
			[Token(Token = "0x601AF49")]
			[Address(RVA = "0x141DA80", Offset = "0x141C680", VA = "0x18141DA80")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601AF4A RID: 110410 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AF4A")]
		[Address(RVA = "0x141D710", Offset = "0x141C310", VA = "0x18141D710")]
		public void Init(bool isActive)
		{
		}

		// Token: 0x0601AF4B RID: 110411 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AF4B")]
		[Address(RVA = "0x141D800", Offset = "0x141C400", VA = "0x18141D800")]
		public void Render(bool isActive, RoguelikeCommonOuterBuffLine.Direction direction, float delay)
		{
		}

		// Token: 0x0601AF4C RID: 110412 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AF4C")]
		[Address(RVA = "0x141DA20", Offset = "0x141C620", VA = "0x18141DA20")]
		public RoguelikeCommonOuterBuffLine()
		{
		}

		// Token: 0x0402296D RID: 141677
		[Token(Token = "0x402296D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIAnimationLocation _activeAnim;

		// Token: 0x0402296E RID: 141678
		[Token(Token = "0x402296E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string _toBuffId;

		// Token: 0x0402296F RID: 141679
		[Token(Token = "0x402296F")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RoguelikeCommonOuterBuffLinePlugin _plugin;

		// Token: 0x04022970 RID: 141680
		[Token(Token = "0x4022970")]
		[FieldOffset(Offset = "0x38")]
		private Tween m_tween;

		// Token: 0x04022971 RID: 141681
		[Token(Token = "0x4022971")]
		[FieldOffset(Offset = "0x40")]
		private bool m_isActive;

		// Token: 0x04022972 RID: 141682
		[Token(Token = "0x4022972")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_toBuffId;

		// Token: 0x04022973 RID: 141683
		[Token(Token = "0x4022973")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04022974 RID: 141684
		[Token(Token = "0x4022974")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04022975 RID: 141685
		[Token(Token = "0x4022975")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004500 RID: 17664
		[Token(Token = "0x2004500")]
		public enum Direction
		{
			// Token: 0x04022977 RID: 141687
			[Token(Token = "0x4022977")]
			FORWARD,
			// Token: 0x04022978 RID: 141688
			[Token(Token = "0x4022978")]
			BACKWARD
		}
	}
}
