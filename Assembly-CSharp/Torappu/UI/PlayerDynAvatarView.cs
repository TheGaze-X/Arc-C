using System;
using AdvancedInspector;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003AEE RID: 15086
	[Token(Token = "0x2003AEE")]
	public class PlayerDynAvatarView : MonoBehaviour, IHotfixable
	{
		// Token: 0x170038F6 RID: 14582
		// (get) Token: 0x06017C81 RID: 97409 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170038F6")]
		public UIColorGraphic colorGraphic
		{
			[Token(Token = "0x6017C81")]
			[Address(RVA = "0x1004560", Offset = "0x1003160", VA = "0x181004560")]
			get
			{
				return null;
			}
		}

		// Token: 0x06017C82 RID: 97410 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017C82")]
		[Address(RVA = "0x1003FD0", Offset = "0x1002BD0", VA = "0x181003FD0")]
		protected void Awake()
		{
		}

		// Token: 0x06017C83 RID: 97411 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017C83")]
		[Address(RVA = "0x1004090", Offset = "0x1002C90", VA = "0x181004090")]
		protected void OnEnable()
		{
		}

		// Token: 0x06017C84 RID: 97412 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017C84")]
		[Address(RVA = "0x1004280", Offset = "0x1002E80", VA = "0x181004280")]
		private void _LoadSpine()
		{
		}

		// Token: 0x06017C85 RID: 97413 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017C85")]
		[Address(RVA = "0x1004310", Offset = "0x1002F10", VA = "0x181004310")]
		private void _ReplayAnimation()
		{
		}

		// Token: 0x06017C86 RID: 97414 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017C86")]
		[Address(RVA = "0x1004450", Offset = "0x1003050", VA = "0x181004450")]
		private void _ReplaySpine()
		{
		}

		// Token: 0x06017C87 RID: 97415 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017C87")]
		[Address(RVA = "0x10044C0", Offset = "0x10030C0", VA = "0x1810044C0")]
		public PlayerDynAvatarView()
		{
		}

		// Token: 0x0401CB80 RID: 117632
		[Token(Token = "0x401CB80")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIAnimationLocation _animLocation;

		// Token: 0x0401CB81 RID: 117633
		[Token(Token = "0x401CB81")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIColorGraphic _colorGraphic;

		// Token: 0x0401CB82 RID: 117634
		[Token(Token = "0x401CB82")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UISpineHolder _spineHolder;

		// Token: 0x0401CB83 RID: 117635
		[Token(Token = "0x401CB83")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[ReadOnly]
		private string _spineId;

		// Token: 0x0401CB84 RID: 117636
		[Token(Token = "0x401CB84")]
		[FieldOffset(Offset = "0x40")]
		private Tween m_animTween;

		// Token: 0x0401CB85 RID: 117637
		[Token(Token = "0x401CB85")]
		[FieldOffset(Offset = "0x48")]
		private UIDynAvatarSpineAdapter m_spineAdapter;

		// Token: 0x0401CB86 RID: 117638
		[Token(Token = "0x401CB86")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_colorGraphic;

		// Token: 0x0401CB87 RID: 117639
		[Token(Token = "0x401CB87")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Awake;

		// Token: 0x0401CB88 RID: 117640
		[Token(Token = "0x401CB88")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnEnable;

		// Token: 0x0401CB89 RID: 117641
		[Token(Token = "0x401CB89")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__LoadSpine;

		// Token: 0x0401CB8A RID: 117642
		[Token(Token = "0x401CB8A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__ReplayAnimation;

		// Token: 0x0401CB8B RID: 117643
		[Token(Token = "0x401CB8B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__ReplaySpine;

		// Token: 0x0401CB8C RID: 117644
		[Token(Token = "0x401CB8C")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
