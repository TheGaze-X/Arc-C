using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Effects
{
	// Token: 0x0200323D RID: 12861
	[Token(Token = "0x200323D")]
	public class OnPlayEmitterIf : OnPlayEmitter
	{
		// Token: 0x1700304F RID: 12367
		// (get) Token: 0x06014670 RID: 83568 RVA: 0x00086B80 File Offset: 0x00084D80
		[Token(Token = "0x1700304F")]
		private bool _showMotionMode
		{
			[Token(Token = "0x6014670")]
			[Address(RVA = "0xCA65F0", Offset = "0xCA51F0", VA = "0x180CA65F0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17003050 RID: 12368
		// (get) Token: 0x06014671 RID: 83569 RVA: 0x00086B98 File Offset: 0x00084D98
		[Token(Token = "0x17003050")]
		private bool _showBuffKey
		{
			[Token(Token = "0x6014671")]
			[Address(RVA = "0xCA6590", Offset = "0xCA5190", VA = "0x180CA6590")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17003051 RID: 12369
		// (get) Token: 0x06014672 RID: 83570 RVA: 0x00086BB0 File Offset: 0x00084DB0
		[Token(Token = "0x17003051")]
		private bool _ownerSpineFaceToMatch
		{
			[Token(Token = "0x6014672")]
			[Address(RVA = "0xCA6530", Offset = "0xCA5130", VA = "0x180CA6530")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06014673 RID: 83571 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014673")]
		[Address(RVA = "0xCA6200", Offset = "0xCA4E00", VA = "0x180CA6200", Slot = "5")]
		public override void OnPlay()
		{
		}

		// Token: 0x06014674 RID: 83572 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014674")]
		[Address(RVA = "0xCA6450", Offset = "0xCA5050", VA = "0x180CA6450")]
		public OnPlayEmitterIf()
		{
		}

		// Token: 0x06014675 RID: 83573 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014675")]
		[Address(RVA = "0xCA63F0", Offset = "0xCA4FF0", VA = "0x180CA63F0")]
		private void <>xLuaBaseProxy_OnPlay()
		{
		}

		// Token: 0x0401815E RID: 98654
		[Token(Token = "0x401815E")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Enum(true, EnumDisplay.Checkbox)]
		private OnPlayEmitterIf.CheckType _checkType;

		// Token: 0x0401815F RID: 98655
		[Token(Token = "0x401815F")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		[Inspect("_showMotionMode")]
		private MotionMode _motionMode;

		// Token: 0x04018160 RID: 98656
		[Token(Token = "0x4018160")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Inspect("_showBuffKey")]
		private string _buffKey;

		// Token: 0x04018161 RID: 98657
		[Token(Token = "0x4018161")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Inspect("_ownerSpineFaceToMatch")]
		private bool _playWhenFaceToBack;

		// Token: 0x04018162 RID: 98658
		[Token(Token = "0x4018162")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get__showMotionMode;

		// Token: 0x04018163 RID: 98659
		[Token(Token = "0x4018163")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get__showBuffKey;

		// Token: 0x04018164 RID: 98660
		[Token(Token = "0x4018164")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get__ownerSpineFaceToMatch;

		// Token: 0x04018165 RID: 98661
		[Token(Token = "0x4018165")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnPlay;

		// Token: 0x04018166 RID: 98662
		[Token(Token = "0x4018166")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200323E RID: 12862
		[Token(Token = "0x200323E")]
		[Flags]
		public enum CheckType
		{
			// Token: 0x04018168 RID: 98664
			[Token(Token = "0x4018168")]
			MOTION_MODE = 1,
			// Token: 0x04018169 RID: 98665
			[Token(Token = "0x4018169")]
			OWNER_CONTAINS_BUFF = 2,
			// Token: 0x0401816A RID: 98666
			[Token(Token = "0x401816A")]
			OWNER_SPINE_FACE_TO_MATCH = 4
		}
	}
}
