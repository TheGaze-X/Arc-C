using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using Il2CppDummyDll;
using UnityEngine;

namespace Vuplex.WebView.Internal
{
	// Token: 0x0200008E RID: 142
	[Token(Token = "0x200008E")]
	public class NativeKeyboardListener : MonoBehaviour
	{
		// Token: 0x1400004F RID: 79
		// (add) Token: 0x0600043F RID: 1087 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000440 RID: 1088 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400004F")]
		public event EventHandler ImeCompositionCancelled
		{
			[Token(Token = "0x600043F")]
			[Address(RVA = "0x5BD0EB0", Offset = "0x5BCFAB0", VA = "0x185BD0EB0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000440")]
			[Address(RVA = "0x5BD1210", Offset = "0x5BCFE10", VA = "0x185BD1210")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000050 RID: 80
		// (add) Token: 0x06000441 RID: 1089 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000442 RID: 1090 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000050")]
		public event EventHandler<EventArgs<string>> ImeCompositionChanged
		{
			[Token(Token = "0x6000441")]
			[Address(RVA = "0x5BD0F50", Offset = "0x5BCFB50", VA = "0x185BD0F50")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000442")]
			[Address(RVA = "0x5BD12B0", Offset = "0x5BCFEB0", VA = "0x185BD12B0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000051 RID: 81
		// (add) Token: 0x06000443 RID: 1091 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000444 RID: 1092 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000051")]
		public event EventHandler<EventArgs<string>> ImeCompositionFinished
		{
			[Token(Token = "0x6000443")]
			[Address(RVA = "0x5BD1000", Offset = "0x5BCFC00", VA = "0x185BD1000")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000444")]
			[Address(RVA = "0x5BD1360", Offset = "0x5BCFF60", VA = "0x185BD1360")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000052 RID: 82
		// (add) Token: 0x06000445 RID: 1093 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000446 RID: 1094 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000052")]
		public event EventHandler<KeyboardEventArgs> KeyDownReceived
		{
			[Token(Token = "0x6000445")]
			[Address(RVA = "0x5BD10B0", Offset = "0x5BCFCB0", VA = "0x185BD10B0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000446")]
			[Address(RVA = "0x5BD1410", Offset = "0x5BD0010", VA = "0x185BD1410")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000053 RID: 83
		// (add) Token: 0x06000447 RID: 1095 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000448 RID: 1096 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000053")]
		public event EventHandler<KeyboardEventArgs> KeyUpReceived
		{
			[Token(Token = "0x6000447")]
			[Address(RVA = "0x5BD1160", Offset = "0x5BCFD60", VA = "0x185BD1160")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000448")]
			[Address(RVA = "0x5BD14C0", Offset = "0x5BD00C0", VA = "0x185BD14C0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06000449 RID: 1097 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000449")]
		[Address(RVA = "0x5BCDAF0", Offset = "0x5BCC6F0", VA = "0x185BCDAF0")]
		public static NativeKeyboardListener Instantiate()
		{
			return null;
		}

		// Token: 0x0600044A RID: 1098 RVA: 0x00002700 File Offset: 0x00000900
		[Token(Token = "0x600044A")]
		[Address(RVA = "0x5BCDDC0", Offset = "0x5BCC9C0", VA = "0x185BCDDC0")]
		private bool _areKeysUndetectableThroughInputStringPressed()
		{
			return default(bool);
		}

		// Token: 0x0600044B RID: 1099 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600044B")]
		[Address(RVA = "0x5BCDAE0", Offset = "0x5BCC6E0", VA = "0x185BCDAE0")]
		private void Awake()
		{
		}

		// Token: 0x0600044C RID: 1100 RVA: 0x00002718 File Offset: 0x00000918
		[Token(Token = "0x600044C")]
		[Address(RVA = "0x5BCFA70", Offset = "0x5BCE670", VA = "0x185BCFA70")]
		private bool _determineIfImeShouldBeEnabled()
		{
			return default(bool);
		}

		// Token: 0x0600044D RID: 1101 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600044D")]
		[Address(RVA = "0x5BCFAC0", Offset = "0x5BCE6C0", VA = "0x185BCFAC0")]
		private void _enableImeIfNeeded()
		{
		}

		// Token: 0x0600044E RID: 1102 RVA: 0x00002730 File Offset: 0x00000930
		[Token(Token = "0x600044E")]
		[Address(RVA = "0x5BCFB90", Offset = "0x5BCE790", VA = "0x185BCFB90")]
		private KeyModifier _getModifiers()
		{
			return KeyModifier.None;
		}

		// Token: 0x0600044F RID: 1103 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600044F")]
		private static Func<TArg, TReturn> _memoize<TArg, TReturn>(Func<TArg, TReturn> function)
		{
			return null;
		}

		// Token: 0x06000450 RID: 1104 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000450")]
		[Address(RVA = "0x5BCDB70", Offset = "0x5BCC770", VA = "0x185BCDB70")]
		private void OnGUI()
		{
		}

		// Token: 0x06000451 RID: 1105 RVA: 0x00002748 File Offset: 0x00000948
		[Token(Token = "0x6000451")]
		[Address(RVA = "0x5BCFE70", Offset = "0x5BCEA70", VA = "0x185BCFE70")]
		private bool _processInputString()
		{
			return default(bool);
		}

		// Token: 0x06000452 RID: 1106 RVA: 0x00002760 File Offset: 0x00000960
		[Token(Token = "0x6000452")]
		[Address(RVA = "0x5BCFC30", Offset = "0x5BCE830", VA = "0x185BCFC30")]
		private bool _processIme()
		{
			return default(bool);
		}

		// Token: 0x06000453 RID: 1107 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000453")]
		[Address(RVA = "0x5BD0140", Offset = "0x5BCED40", VA = "0x185BD0140")]
		private void _processKeysPressed()
		{
		}

		// Token: 0x06000454 RID: 1108 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000454")]
		[Address(RVA = "0x5BD01A0", Offset = "0x5BCEDA0", VA = "0x185BD01A0")]
		private void _processKeysReleased()
		{
		}

		// Token: 0x06000455 RID: 1109 RVA: 0x00002778 File Offset: 0x00000978
		[Token(Token = "0x6000455")]
		[Address(RVA = "0x5BD05D0", Offset = "0x5BCF1D0", VA = "0x185BD05D0")]
		private bool _processKeysUndetectableThroughInputString()
		{
			return default(bool);
		}

		// Token: 0x06000456 RID: 1110 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000456")]
		[Address(RVA = "0x5BD0980", Offset = "0x5BCF580", VA = "0x185BD0980")]
		private void _processModifierKeysOnly()
		{
		}

		// Token: 0x06000457 RID: 1111 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000457")]
		[Address(RVA = "0x5BD0D80", Offset = "0x5BCF980", VA = "0x185BD0D80")]
		private void _repeatKey()
		{
		}

		// Token: 0x06000458 RID: 1112 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000458")]
		[Address(RVA = "0x5BCDCA0", Offset = "0x5BCC8A0", VA = "0x185BCDCA0")]
		private void Update()
		{
		}

		// Token: 0x06000459 RID: 1113 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000459")]
		[Address(RVA = "0x5BCF970", Offset = "0x5BCE570", VA = "0x185BCF970")]
		public NativeKeyboardListener()
		{
		}

		// Token: 0x040001FB RID: 507
		[Token(Token = "0x40001FB")]
		[FieldOffset(Offset = "0x40")]
		private Regex _alphanumericRegex;

		// Token: 0x040001FC RID: 508
		[Token(Token = "0x40001FC")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Func<string, bool> _hasValidUnityKeyName;

		// Token: 0x040001FD RID: 509
		[Token(Token = "0x40001FD")]
		[FieldOffset(Offset = "0x48")]
		private bool? _imeShouldBeEnabled;

		// Token: 0x040001FE RID: 510
		[Token(Token = "0x40001FE")]
		[FieldOffset(Offset = "0x50")]
		private List<string> _keysDown;

		// Token: 0x040001FF RID: 511
		[Token(Token = "0x40001FF")]
		[FieldOffset(Offset = "0x8")]
		private static readonly string[] _keyValuesUndetectableThroughInputString;

		// Token: 0x04000200 RID: 512
		[Token(Token = "0x4000200")]
		[FieldOffset(Offset = "0x58")]
		private NativeKeyboardListener.KeyRepeatState _keyRepeatState;

		// Token: 0x04000201 RID: 513
		[Token(Token = "0x4000201")]
		[FieldOffset(Offset = "0x10")]
		private static readonly string[] _keyValues;

		// Token: 0x04000202 RID: 514
		[Token(Token = "0x4000202")]
		[FieldOffset(Offset = "0x60")]
		private bool _legacyInputManagerDisabled;

		// Token: 0x04000203 RID: 515
		[Token(Token = "0x4000203")]
		[FieldOffset(Offset = "0x64")]
		private KeyModifier _modifiersDown;

		// Token: 0x04000204 RID: 516
		[Token(Token = "0x4000204")]
		[FieldOffset(Offset = "0x18")]
		private static readonly Func<string, string[]> _getPotentialUnityKeyNames;

		// Token: 0x04000205 RID: 517
		[Token(Token = "0x4000205")]
		private const string REPEAT_KEY_METHOD_NAME = "_repeatKey";

		// Token: 0x04000206 RID: 518
		[Token(Token = "0x4000206")]
		[FieldOffset(Offset = "0x68")]
		private string _previousImeCompositionString;

		// Token: 0x0200008F RID: 143
		[Token(Token = "0x200008F")]
		private class KeyRepeatState
		{
			// Token: 0x0600045B RID: 1115 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600045B")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public KeyRepeatState()
			{
			}

			// Token: 0x04000207 RID: 519
			[Token(Token = "0x4000207")]
			[FieldOffset(Offset = "0x10")]
			public string Key;

			// Token: 0x04000208 RID: 520
			[Token(Token = "0x4000208")]
			[FieldOffset(Offset = "0x18")]
			public bool HasRepeated;
		}
	}
}
