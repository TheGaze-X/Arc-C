using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FullInspector.Internal;
using Il2CppDummyDll;
using UnityEngine;

namespace FullInspector
{
	// Token: 0x02007BFA RID: 31738
	[Token(Token = "0x2007BFA")]
	public abstract class BaseObject : fiValueProxyEditor, fiIValueProxyAPI, ISerializedObject, ISerializationCallbackReceiver
	{
		// Token: 0x17006803 RID: 26627
		// (get) Token: 0x0602C674 RID: 181876 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602C675 RID: 181877 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006803")]
		private List<UnityEngine.Object> SerializedObjectReferences
		{
			[Token(Token = "0x602C674")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "12")]
			get
			{
				return null;
			}
			[Token(Token = "0x602C675")]
			[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40", Slot = "13")]
			set
			{
			}
		}

		// Token: 0x17006804 RID: 26628
		// (get) Token: 0x0602C676 RID: 181878 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602C677 RID: 181879 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006804")]
		private List<string> SerializedStateKeys
		{
			[Token(Token = "0x602C676")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80", Slot = "14")]
			get
			{
				return null;
			}
			[Token(Token = "0x602C677")]
			[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670", Slot = "15")]
			set
			{
			}
		}

		// Token: 0x17006805 RID: 26629
		// (get) Token: 0x0602C678 RID: 181880 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602C679 RID: 181881 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006805")]
		private List<string> SerializedStateValues
		{
			[Token(Token = "0x602C678")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70", Slot = "16")]
			get
			{
				return null;
			}
			[Token(Token = "0x602C679")]
			[Address(RVA = "0x4E6EC0", Offset = "0x4E5AC0", VA = "0x1804E6EC0", Slot = "17")]
			set
			{
			}
		}

		// Token: 0x17006806 RID: 26630
		// (get) Token: 0x0602C67A RID: 181882 RVA: 0x000E0040 File Offset: 0x000DE240
		// (set) Token: 0x0602C67B RID: 181883 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006806")]
		private bool IsRestored
		{
			[Token(Token = "0x602C67A")]
			[Address(RVA = "0x73B8F0", Offset = "0x73A4F0", VA = "0x18073B8F0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x602C67B")]
			[Address(RVA = "0x73B920", Offset = "0x73A520", VA = "0x18073B920", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0602C67C RID: 181884 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C67C")]
		[Address(RVA = "0x2854160", Offset = "0x2852D60", VA = "0x182854160", Slot = "8")]
		private void RestoreState()
		{
		}

		// Token: 0x0602C67D RID: 181885 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C67D")]
		[Address(RVA = "0x28541A0", Offset = "0x2852DA0", VA = "0x1828541A0", Slot = "9")]
		private void SaveState()
		{
		}

		// Token: 0x0602C67E RID: 181886 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C67E")]
		[Address(RVA = "0x28541E0", Offset = "0x2852DE0", VA = "0x1828541E0", Slot = "19")]
		private void OnAfterDeserialize()
		{
		}

		// Token: 0x0602C67F RID: 181887 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C67F")]
		[Address(RVA = "0x2854220", Offset = "0x2852E20", VA = "0x182854220", Slot = "18")]
		private void OnBeforeSerialize()
		{
		}

		// Token: 0x17006807 RID: 26631
		// (get) Token: 0x0602C680 RID: 181888 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602C681 RID: 181889 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006807")]
		private object Value
		{
			[Token(Token = "0x602C680")]
			[Address(RVA = "0xEB5120", Offset = "0xEB3D20", VA = "0x180EB5120", Slot = "4")]
			get
			{
				return null;
			}
			[Token(Token = "0x602C681")]
			[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "5")]
			set
			{
			}
		}

		// Token: 0x0602C682 RID: 181890 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C682")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "6")]
		private void SaveState()
		{
		}

		// Token: 0x0602C683 RID: 181891 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C683")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "7")]
		private void LoadState()
		{
		}

		// Token: 0x0602C684 RID: 181892 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C684")]
		[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
		protected BaseObject()
		{
		}

		// Token: 0x04040299 RID: 262809
		[Token(Token = "0x4040299")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		[NotSerialized]
		[HideInInspector]
		private List<UnityEngine.Object> _objectReferences;

		// Token: 0x0404029A RID: 262810
		[Token(Token = "0x404029A")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[NotSerialized]
		[HideInInspector]
		private List<string> _serializedStateKeys;

		// Token: 0x0404029B RID: 262811
		[Token(Token = "0x404029B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[NotSerialized]
		[HideInInspector]
		private List<string> _serializedStateValues;
	}
}
