using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.LowLevel;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem
{
	// Token: 0x020000B8 RID: 184
	[Token(Token = "0x20000B8")]
	[InputControlLayout(stateType = typeof(TouchscreenState), isGenericTypeOfDevice = true)]
	public class Touchscreen : Pointer, IInputStateCallbackReceiver, IEventMerger, ICustomDeviceReset
	{
		// Token: 0x17000290 RID: 656
		// (get) Token: 0x060009EB RID: 2539 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060009EC RID: 2540 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000290")]
		public TouchControl primaryTouch
		{
			[Token(Token = "0x60009EB")]
			[Address(RVA = "0x4E84370", Offset = "0x4E82F70", VA = "0x184E84370")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60009EC")]
			[Address(RVA = "0x55CD2B0", Offset = "0x55CBEB0", VA = "0x1855CD2B0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000291 RID: 657
		// (get) Token: 0x060009ED RID: 2541 RVA: 0x00005190 File Offset: 0x00003390
		// (set) Token: 0x060009EE RID: 2542 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000291")]
		public ReadOnlyArray<TouchControl> touches
		{
			[Token(Token = "0x60009ED")]
			[Address(RVA = "0x569BBE0", Offset = "0x569A7E0", VA = "0x18569BBE0")]
			[CompilerGenerated]
			get
			{
				return default(ReadOnlyArray<TouchControl>);
			}
			[Token(Token = "0x60009EE")]
			[Address(RVA = "0x569BCC0", Offset = "0x569A8C0", VA = "0x18569BCC0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000292 RID: 658
		// (get) Token: 0x060009EF RID: 2543 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060009F0 RID: 2544 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000292")]
		protected TouchControl[] touchControlArray
		{
			[Token(Token = "0x60009EF")]
			[Address(RVA = "0x16925F0", Offset = "0x16911F0", VA = "0x1816925F0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60009F0")]
			[Address(RVA = "0x569BC50", Offset = "0x569A850", VA = "0x18569BC50")]
			set
			{
			}
		}

		// Token: 0x17000293 RID: 659
		// (get) Token: 0x060009F1 RID: 2545 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060009F2 RID: 2546 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000293")]
		public new static Touchscreen current
		{
			[Token(Token = "0x60009F1")]
			[Address(RVA = "0x569BBA0", Offset = "0x569A7A0", VA = "0x18569BBA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60009F2")]
			[Address(RVA = "0x569BBF0", Offset = "0x569A7F0", VA = "0x18569BBF0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		// Token: 0x060009F3 RID: 2547 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009F3")]
		[Address(RVA = "0x569A690", Offset = "0x5699290", VA = "0x18569A690", Slot = "17")]
		public override void MakeCurrent()
		{
		}

		// Token: 0x060009F4 RID: 2548 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009F4")]
		[Address(RVA = "0x569AB90", Offset = "0x5699790", VA = "0x18569AB90", Slot = "19")]
		protected override void OnRemoved()
		{
		}

		// Token: 0x060009F5 RID: 2549 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009F5")]
		[Address(RVA = "0x569A2A0", Offset = "0x5698EA0", VA = "0x18569A2A0", Slot = "13")]
		protected override void FinishSetup()
		{
		}

		// Token: 0x060009F6 RID: 2550 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009F6")]
		[Address(RVA = "0x569A810", Offset = "0x5699410", VA = "0x18569A810")]
		protected new void OnNextUpdate()
		{
		}

		// Token: 0x060009F7 RID: 2551 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009F7")]
		[Address(RVA = "0x569AC20", Offset = "0x5699820", VA = "0x18569AC20")]
		protected new void OnStateEvent(InputEventPtr eventPtr)
		{
		}

		// Token: 0x060009F8 RID: 2552 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009F8")]
		[Address(RVA = "0x569BB80", Offset = "0x569A780", VA = "0x18569BB80", Slot = "22")]
		private void OnNextUpdate()
		{
		}

		// Token: 0x060009F9 RID: 2553 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009F9")]
		[Address(RVA = "0x569BB90", Offset = "0x569A790", VA = "0x18569BB90", Slot = "23")]
		private void OnStateEvent(InputEventPtr eventPtr)
		{
		}

		// Token: 0x060009FA RID: 2554 RVA: 0x000051A8 File Offset: 0x000033A8
		[Token(Token = "0x60009FA")]
		[Address(RVA = "0x569B8F0", Offset = "0x569A4F0", VA = "0x18569B8F0", Slot = "24")]
		private bool GetStateOffsetForEvent(InputControl control, InputEventPtr eventPtr, ref uint offset)
		{
			return default(bool);
		}

		// Token: 0x060009FB RID: 2555 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009FB")]
		[Address(RVA = "0x569B420", Offset = "0x569A020", VA = "0x18569B420", Slot = "26")]
		private void Reset()
		{
		}

		// Token: 0x060009FC RID: 2556 RVA: 0x000051C0 File Offset: 0x000033C0
		[Token(Token = "0x60009FC")]
		[Address(RVA = "0x569A6F0", Offset = "0x56992F0", VA = "0x18569A6F0")]
		internal static bool MergeForward(InputEventPtr currentEventPtr, InputEventPtr nextEventPtr)
		{
			return default(bool);
		}

		// Token: 0x060009FD RID: 2557 RVA: 0x000051D8 File Offset: 0x000033D8
		[Token(Token = "0x60009FD")]
		[Address(RVA = "0x569B7D0", Offset = "0x569A3D0", VA = "0x18569B7D0", Slot = "25")]
		private bool MergeForward(InputEventPtr currentEventPtr, InputEventPtr nextEventPtr)
		{
			return default(bool);
		}

		// Token: 0x060009FE RID: 2558 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009FE")]
		[Address(RVA = "0x569B360", Offset = "0x5699F60", VA = "0x18569B360")]
		private static void TriggerTap(TouchControl control, ref TouchState state, InputEventPtr eventPtr)
		{
		}

		// Token: 0x060009FF RID: 2559 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009FF")]
		[Address(RVA = "0x55CDA70", Offset = "0x55CC670", VA = "0x1855CDA70")]
		public Touchscreen()
		{
		}

		// Token: 0x0400042A RID: 1066
		[Token(Token = "0x400042A")]
		[FieldOffset(Offset = "0x8")]
		internal static float s_TapTime;

		// Token: 0x0400042B RID: 1067
		[Token(Token = "0x400042B")]
		[FieldOffset(Offset = "0xC")]
		internal static float s_TapDelayTime;

		// Token: 0x0400042C RID: 1068
		[Token(Token = "0x400042C")]
		[FieldOffset(Offset = "0x10")]
		internal static float s_TapRadiusSquared;
	}
}
