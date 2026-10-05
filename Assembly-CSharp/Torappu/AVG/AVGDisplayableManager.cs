using System;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.AVG
{
	// Token: 0x02001E4A RID: 7754
	[Token(Token = "0x2001E4A")]
	public class AVGDisplayableManager : IHotfixable
	{
		// Token: 0x0600BFDA RID: 49114 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BFDA")]
		[Address(RVA = "0x33DCE70", Offset = "0x33DBA70", VA = "0x1833DCE70")]
		public AVGDisplayableManager(AVGDisplayableManager.Param param)
		{
		}

		// Token: 0x0600BFDB RID: 49115 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BFDB")]
		[Address(RVA = "0x33DC190", Offset = "0x33DAD90", VA = "0x1833DC190")]
		public void OnReset()
		{
		}

		// Token: 0x0600BFDC RID: 49116 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BFDC")]
		[Address(RVA = "0x33DC0F0", Offset = "0x33DACF0", VA = "0x1833DC0F0")]
		public void Display(Command command, out Tween tween)
		{
		}

		// Token: 0x0600BFDD RID: 49117 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BFDD")]
		[Address(RVA = "0x33DC3B0", Offset = "0x33DAFB0", VA = "0x1833DC3B0")]
		private void _DisplayInternal(Command command, out Tween tween)
		{
		}

		// Token: 0x0600BFDE RID: 49118 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600BFDE")]
		[Address(RVA = "0x33DC870", Offset = "0x33DB470", VA = "0x1833DC870")]
		private AVGDisplayableHolder _GenerateDisplayable(AVGDisplaySlot slot, AVGDisplayableType type)
		{
			return null;
		}

		// Token: 0x0600BFDF RID: 49119 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600BFDF")]
		[Address(RVA = "0x33DCCF0", Offset = "0x33DB8F0", VA = "0x1833DCCF0")]
		private Transform _GetSlotContainer(AVGDisplaySlot slot)
		{
			return null;
		}

		// Token: 0x0600BFE0 RID: 49120 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600BFE0")]
		[Address(RVA = "0x33DCDA0", Offset = "0x33DB9A0", VA = "0x1833DCDA0")]
		private string _GetTypePath(AVGDisplayableType type)
		{
			return null;
		}

		// Token: 0x0600BFE1 RID: 49121 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BFE1")]
		[Address(RVA = "0x33DC1F0", Offset = "0x33DADF0", VA = "0x1833DC1F0")]
		private void _ClearHolders()
		{
		}

		// Token: 0x0400C11F RID: 49439
		[Token(Token = "0x400C11F")]
		[FieldOffset(Offset = "0x10")]
		private Transform m_bgOverlay;

		// Token: 0x0400C120 RID: 49440
		[Token(Token = "0x400C120")]
		[FieldOffset(Offset = "0x18")]
		private Transform m_charOverlay;

		// Token: 0x0400C121 RID: 49441
		[Token(Token = "0x400C121")]
		[FieldOffset(Offset = "0x20")]
		private Transform m_cgOverlay;

		// Token: 0x0400C122 RID: 49442
		[Token(Token = "0x400C122")]
		[FieldOffset(Offset = "0x28")]
		private Dictionary<string, AVGDisplayableManager.HolderContext> m_holders;

		// Token: 0x0400C123 RID: 49443
		[Token(Token = "0x400C123")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0400C124 RID: 49444
		[Token(Token = "0x400C124")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnReset;

		// Token: 0x0400C125 RID: 49445
		[Token(Token = "0x400C125")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Display;

		// Token: 0x0400C126 RID: 49446
		[Token(Token = "0x400C126")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__DisplayInternal;

		// Token: 0x0400C127 RID: 49447
		[Token(Token = "0x400C127")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__GenerateDisplayable;

		// Token: 0x0400C128 RID: 49448
		[Token(Token = "0x400C128")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__GetSlotContainer;

		// Token: 0x0400C129 RID: 49449
		[Token(Token = "0x400C129")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__GetTypePath;

		// Token: 0x0400C12A RID: 49450
		[Token(Token = "0x400C12A")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__ClearHolders;

		// Token: 0x02001E4B RID: 7755
		[Token(Token = "0x2001E4B")]
		public struct Param
		{
			// Token: 0x0600BFE2 RID: 49122 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600BFE2")]
			[Address(RVA = "0x17F8010", Offset = "0x17F6C10", VA = "0x1817F8010")]
			public Param(Transform _bgOver, Transform _charOver, Transform _cgOver)
			{
			}

			// Token: 0x0400C12B RID: 49451
			[Token(Token = "0x400C12B")]
			[FieldOffset(Offset = "0x0")]
			public Transform bgOverlay;

			// Token: 0x0400C12C RID: 49452
			[Token(Token = "0x400C12C")]
			[FieldOffset(Offset = "0x8")]
			public Transform charOverlay;

			// Token: 0x0400C12D RID: 49453
			[Token(Token = "0x400C12D")]
			[FieldOffset(Offset = "0x10")]
			public Transform cgOverlay;
		}

		// Token: 0x02001E4C RID: 7756
		[Token(Token = "0x2001E4C")]
		private struct HolderContext
		{
			// Token: 0x0400C12E RID: 49454
			[Token(Token = "0x400C12E")]
			[FieldOffset(Offset = "0x0")]
			public AVGDisplaySlot slot;

			// Token: 0x0400C12F RID: 49455
			[Token(Token = "0x400C12F")]
			[FieldOffset(Offset = "0x4")]
			public AVGDisplayableType type;

			// Token: 0x0400C130 RID: 49456
			[Token(Token = "0x400C130")]
			[FieldOffset(Offset = "0x8")]
			public AVGDisplayableHolder holder;
		}
	}
}
