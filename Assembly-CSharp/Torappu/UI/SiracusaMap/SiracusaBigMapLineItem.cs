using System;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SiracusaMap
{
	// Token: 0x02003F75 RID: 16245
	[Token(Token = "0x2003F75")]
	public class SiracusaBigMapLineItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601934C RID: 103244 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601934C")]
		[Address(RVA = "0x11E2100", Offset = "0x11E0D00", VA = "0x1811E2100")]
		public void Reset(SiracusaBigMapLineItem.Options options)
		{
		}

		// Token: 0x0601934D RID: 103245 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601934D")]
		[Address(RVA = "0x11E2580", Offset = "0x11E1180", VA = "0x1811E2580")]
		private void _DoExpandAnim(float lineLength, float preDelay)
		{
		}

		// Token: 0x0601934E RID: 103246 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601934E")]
		[Address(RVA = "0x11E23D0", Offset = "0x11E0FD0", VA = "0x1811E23D0")]
		private void _CleanAllTweens()
		{
		}

		// Token: 0x0601934F RID: 103247 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601934F")]
		[Address(RVA = "0x11E2910", Offset = "0x11E1510", VA = "0x1811E2910")]
		public SiracusaBigMapLineItem()
		{
		}

		// Token: 0x0401F412 RID: 128018
		[Token(Token = "0x401F412")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private AnimationClip _clipExpand;

		// Token: 0x0401F413 RID: 128019
		[Token(Token = "0x401F413")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Tooltip("The line must starts from left to right(anchor.x=0)")]
		private RectTransform _transLine;

		// Token: 0x0401F414 RID: 128020
		[Token(Token = "0x401F414")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _lineExpandDur;

		// Token: 0x0401F415 RID: 128021
		[Token(Token = "0x401F415")]
		[FieldOffset(Offset = "0x30")]
		private List<Tween> m_tweens;

		// Token: 0x0401F416 RID: 128022
		[Token(Token = "0x401F416")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Reset;

		// Token: 0x0401F417 RID: 128023
		[Token(Token = "0x401F417")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__DoExpandAnim;

		// Token: 0x0401F418 RID: 128024
		[Token(Token = "0x401F418")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__CleanAllTweens;

		// Token: 0x0401F419 RID: 128025
		[Token(Token = "0x401F419")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003F76 RID: 16246
		[Token(Token = "0x2003F76")]
		public struct Options
		{
			// Token: 0x0401F41A RID: 128026
			[Token(Token = "0x401F41A")]
			[FieldOffset(Offset = "0x0")]
			public Vector2 start;

			// Token: 0x0401F41B RID: 128027
			[Token(Token = "0x401F41B")]
			[FieldOffset(Offset = "0x8")]
			public Vector2 end;

			// Token: 0x0401F41C RID: 128028
			[Token(Token = "0x401F41C")]
			[FieldOffset(Offset = "0x10")]
			public bool useExpandAnim;

			// Token: 0x0401F41D RID: 128029
			[Token(Token = "0x401F41D")]
			[FieldOffset(Offset = "0x14")]
			public float animPreDelay;
		}
	}
}
