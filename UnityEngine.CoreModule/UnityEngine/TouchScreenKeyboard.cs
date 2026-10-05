using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Internal;

namespace UnityEngine
{
	// Token: 0x02000142 RID: 322
	[Token(Token = "0x2000142")]
	[NativeHeader("Runtime/Export/TouchScreenKeyboard/TouchScreenKeyboard.bindings.h")]
	[NativeHeader("Runtime/Input/KeyboardOnScreen.h")]
	[NativeConditional("ENABLE_ONSCREEN_KEYBOARD")]
	public class TouchScreenKeyboard
	{
		// Token: 0x06000B07 RID: 2823
		[Token(Token = "0x6000B07")]
		[Address(RVA = "0x5971980", Offset = "0x5970580", VA = "0x185971980")]
		[FreeFunction("TouchScreenKeyboard_Destroy", IsThreadSafe = true)]
		[MethodImpl(4096)]
		private static extern void Internal_Destroy(IntPtr ptr);

		// Token: 0x06000B08 RID: 2824 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B08")]
		[Address(RVA = "0x5971760", Offset = "0x5970360", VA = "0x185971760")]
		private void Destroy()
		{
		}

		// Token: 0x06000B09 RID: 2825 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B09")]
		[Address(RVA = "0x5971820", Offset = "0x5970420", VA = "0x185971820", Slot = "1")]
		protected override void Finalize()
		{
		}

		// Token: 0x06000B0A RID: 2826 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B0A")]
		[Address(RVA = "0x5971D80", Offset = "0x5970980", VA = "0x185971D80")]
		public TouchScreenKeyboard(string text, TouchScreenKeyboardType keyboardType, bool autocorrection, bool multiline, bool secure, bool alert, string textPlaceholder, int characterLimit)
		{
		}

		// Token: 0x06000B0B RID: 2827
		[Token(Token = "0x6000B0B")]
		[Address(RVA = "0x5971D20", Offset = "0x5970920", VA = "0x185971D20")]
		[FreeFunction("TouchScreenKeyboard_InternalConstructorHelper")]
		[MethodImpl(4096)]
		private static extern IntPtr TouchScreenKeyboard_InternalConstructorHelper(ref TouchScreenKeyboard_InternalConstructorHelperArguments arguments, string text, string textPlaceholder);

		// Token: 0x17000248 RID: 584
		// (get) Token: 0x06000B0C RID: 2828 RVA: 0x00006288 File Offset: 0x00004488
		[Token(Token = "0x17000248")]
		public static bool isSupported
		{
			[Token(Token = "0x6000B0C")]
			[Address(RVA = "0x5971FE0", Offset = "0x5970BE0", VA = "0x185971FE0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000249 RID: 585
		// (get) Token: 0x06000B0D RID: 2829 RVA: 0x000062A0 File Offset: 0x000044A0
		[Token(Token = "0x17000249")]
		internal static bool disableInPlaceEditing
		{
			[Token(Token = "0x6000B0D")]
			[Address(RVA = "0x5971F70", Offset = "0x5970B70", VA = "0x185971F70")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700024A RID: 586
		// (get) Token: 0x06000B0E RID: 2830 RVA: 0x000062B8 File Offset: 0x000044B8
		[Token(Token = "0x1700024A")]
		public static bool isInPlaceEditingAllowed
		{
			[Token(Token = "0x6000B0E")]
			[Address(RVA = "0x5971FB0", Offset = "0x5970BB0", VA = "0x185971FB0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700024B RID: 587
		// (get) Token: 0x06000B0F RID: 2831 RVA: 0x000062D0 File Offset: 0x000044D0
		[Token(Token = "0x1700024B")]
		internal static bool isRequiredToForceOpen
		{
			[Token(Token = "0x6000B0F")]
			[Address(RVA = "0x59719C0", Offset = "0x59705C0", VA = "0x1859719C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000B10 RID: 2832
		[Token(Token = "0x6000B10")]
		[Address(RVA = "0x59719C0", Offset = "0x59705C0", VA = "0x1859719C0")]
		[FreeFunction("TouchScreenKeyboard_IsRequiredToForceOpen")]
		[MethodImpl(4096)]
		private static extern bool IsRequiredToForceOpen();

		// Token: 0x06000B11 RID: 2833 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000B11")]
		[Address(RVA = "0x59719F0", Offset = "0x59705F0", VA = "0x1859719F0")]
		public static TouchScreenKeyboard Open(string text, [DefaultValue("TouchScreenKeyboardType.Default")] TouchScreenKeyboardType keyboardType, [DefaultValue("true")] bool autocorrection, [DefaultValue("false")] bool multiline, [DefaultValue("false")] bool secure, [DefaultValue("false")] bool alert, [DefaultValue("\"\"")] string textPlaceholder, [DefaultValue("0")] int characterLimit)
		{
			return null;
		}

		// Token: 0x06000B12 RID: 2834 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000B12")]
		[Address(RVA = "0x5971B50", Offset = "0x5970750", VA = "0x185971B50")]
		[ExcludeFromDocs]
		public static TouchScreenKeyboard Open(string text, TouchScreenKeyboardType keyboardType, bool autocorrection, bool multiline, bool secure)
		{
			return null;
		}

		// Token: 0x1700024C RID: 588
		// (get) Token: 0x06000B13 RID: 2835
		// (set) Token: 0x06000B14 RID: 2836
		[Token(Token = "0x1700024C")]
		public extern string text { [Token(Token = "0x6000B13")] [Address(RVA = "0x59720F0", Offset = "0x5970CF0", VA = "0x1859720F0")] [NativeName("GetText")] [MethodImpl(4096)] get; [Token(Token = "0x6000B14")] [Address(RVA = "0x5972300", Offset = "0x5970F00", VA = "0x185972300")] [NativeName("SetText")] [MethodImpl(4096)] set; }

		// Token: 0x1700024D RID: 589
		// (set) Token: 0x06000B15 RID: 2837
		[Token(Token = "0x1700024D")]
		public static extern bool hideInput { [Token(Token = "0x6000B15")] [Address(RVA = "0x59721C0", Offset = "0x5970DC0", VA = "0x1859721C0")] [NativeName("SetInputHidden")] [MethodImpl(4096)] set; }

		// Token: 0x1700024E RID: 590
		// (get) Token: 0x06000B16 RID: 2838
		// (set) Token: 0x06000B17 RID: 2839
		[Token(Token = "0x1700024E")]
		public extern bool active { [Token(Token = "0x6000B16")] [Address(RVA = "0x5971EB0", Offset = "0x5970AB0", VA = "0x185971EB0")] [NativeName("IsActive")] [MethodImpl(4096)] get; [Token(Token = "0x6000B17")] [Address(RVA = "0x5972130", Offset = "0x5970D30", VA = "0x185972130")] [NativeName("SetActive")] [MethodImpl(4096)] set; }

		// Token: 0x1700024F RID: 591
		// (get) Token: 0x06000B18 RID: 2840
		[Token(Token = "0x1700024F")]
		public extern TouchScreenKeyboard.Status status { [Token(Token = "0x6000B18")] [Address(RVA = "0x59720B0", Offset = "0x5970CB0", VA = "0x1859720B0")] [NativeName("GetKeyboardStatus")] [MethodImpl(4096)] get; }

		// Token: 0x17000250 RID: 592
		// (set) Token: 0x06000B19 RID: 2841
		[Token(Token = "0x17000250")]
		public extern int characterLimit { [Token(Token = "0x6000B19")] [Address(RVA = "0x5972180", Offset = "0x5970D80", VA = "0x185972180")] [NativeName("SetCharacterLimit")] [MethodImpl(4096)] set; }

		// Token: 0x17000251 RID: 593
		// (get) Token: 0x06000B1A RID: 2842
		[Token(Token = "0x17000251")]
		public extern bool canGetSelection { [Token(Token = "0x6000B1A")] [Address(RVA = "0x5971EF0", Offset = "0x5970AF0", VA = "0x185971EF0")] [NativeName("CanGetSelection")] [MethodImpl(4096)] get; }

		// Token: 0x17000252 RID: 594
		// (get) Token: 0x06000B1B RID: 2843
		[Token(Token = "0x17000252")]
		public extern bool canSetSelection { [Token(Token = "0x6000B1B")] [Address(RVA = "0x5971F30", Offset = "0x5970B30", VA = "0x185971F30")] [NativeName("CanSetSelection")] [MethodImpl(4096)] get; }

		// Token: 0x17000253 RID: 595
		// (get) Token: 0x06000B1C RID: 2844 RVA: 0x000062E8 File Offset: 0x000044E8
		// (set) Token: 0x06000B1D RID: 2845 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000253")]
		public RangeInt selection
		{
			[Token(Token = "0x6000B1C")]
			[Address(RVA = "0x5972060", Offset = "0x5970C60", VA = "0x185972060")]
			get
			{
				return default(RangeInt);
			}
			[Token(Token = "0x6000B1D")]
			[Address(RVA = "0x5972200", Offset = "0x5970E00", VA = "0x185972200")]
			set
			{
			}
		}

		// Token: 0x06000B1E RID: 2846
		[Token(Token = "0x6000B1E")]
		[Address(RVA = "0x5971930", Offset = "0x5970530", VA = "0x185971930")]
		[MethodImpl(4096)]
		private static extern void GetSelection(out int start, out int length);

		// Token: 0x06000B1F RID: 2847
		[Token(Token = "0x6000B1F")]
		[Address(RVA = "0x5971CE0", Offset = "0x59708E0", VA = "0x185971CE0")]
		[MethodImpl(4096)]
		private static extern void SetSelection(int start, int length);

		// Token: 0x04000506 RID: 1286
		[Token(Token = "0x4000506")]
		[FieldOffset(Offset = "0x10")]
		[NonSerialized]
		internal IntPtr m_Ptr;

		// Token: 0x02000143 RID: 323
		[Token(Token = "0x2000143")]
		public enum Status
		{
			// Token: 0x04000509 RID: 1289
			[Token(Token = "0x4000509")]
			Visible,
			// Token: 0x0400050A RID: 1290
			[Token(Token = "0x400050A")]
			Done,
			// Token: 0x0400050B RID: 1291
			[Token(Token = "0x400050B")]
			Canceled,
			// Token: 0x0400050C RID: 1292
			[Token(Token = "0x400050C")]
			LostFocus
		}
	}
}
