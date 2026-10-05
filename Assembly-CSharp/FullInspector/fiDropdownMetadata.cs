using System;
using FullInspector.Internal;
using Il2CppDummyDll;
using UnityEngine;

namespace FullInspector
{
	// Token: 0x02007C03 RID: 31747
	[Token(Token = "0x2007C03")]
	[Serializable]
	public class fiDropdownMetadata : IGraphMetadataItemPersistent, ISerializationCallbackReceiver
	{
		// Token: 0x1700680C RID: 26636
		// (get) Token: 0x0602C6A4 RID: 181924 RVA: 0x000E0070 File Offset: 0x000DE270
		// (set) Token: 0x0602C6A5 RID: 181925 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700680C")]
		public bool IsActive
		{
			[Token(Token = "0x602C6A4")]
			[Address(RVA = "0x2867CD0", Offset = "0x28668D0", VA = "0x182867CD0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x602C6A5")]
			[Address(RVA = "0x2867D70", Offset = "0x2866970", VA = "0x182867D70")]
			set
			{
			}
		}

		// Token: 0x1700680D RID: 26637
		// (get) Token: 0x0602C6A6 RID: 181926 RVA: 0x000E0088 File Offset: 0x000DE288
		[Token(Token = "0x1700680D")]
		public float AnimPercentage
		{
			[Token(Token = "0x602C6A6")]
			[Address(RVA = "0x2867C80", Offset = "0x2866880", VA = "0x182867C80")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700680E RID: 26638
		// (get) Token: 0x0602C6A7 RID: 181927 RVA: 0x000E00A0 File Offset: 0x000DE2A0
		[Token(Token = "0x1700680E")]
		public bool IsAnimating
		{
			[Token(Token = "0x602C6A7")]
			[Address(RVA = "0x2867D20", Offset = "0x2866920", VA = "0x182867D20")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700680F RID: 26639
		// (get) Token: 0x0602C6A8 RID: 181928 RVA: 0x000E00B8 File Offset: 0x000DE2B8
		// (set) Token: 0x0602C6A9 RID: 181929 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700680F")]
		public bool ShouldDisplayDropdownArrow
		{
			[Token(Token = "0x602C6A8")]
			[Address(RVA = "0x2867D60", Offset = "0x2866960", VA = "0x182867D60")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x602C6A9")]
			[Address(RVA = "0x2867EA0", Offset = "0x2866AA0", VA = "0x182867EA0")]
			set
			{
			}
		}

		// Token: 0x0602C6AA RID: 181930 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C6AA")]
		[Address(RVA = "0x2867AE0", Offset = "0x28666E0", VA = "0x182867AE0")]
		public void InvertDefaultState()
		{
		}

		// Token: 0x0602C6AB RID: 181931 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C6AB")]
		[Address(RVA = "0x28679B0", Offset = "0x28665B0", VA = "0x1828679B0")]
		public void ForceHideWithoutAnimation()
		{
		}

		// Token: 0x0602C6AC RID: 181932 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C6AC")]
		[Address(RVA = "0x28679A0", Offset = "0x28665A0", VA = "0x1828679A0")]
		public void ForceDisable()
		{
		}

		// Token: 0x0602C6AD RID: 181933 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C6AD")]
		[Address(RVA = "0x2867B90", Offset = "0x2866790", VA = "0x182867B90", Slot = "5")]
		private void OnBeforeSerialize()
		{
		}

		// Token: 0x0602C6AE RID: 181934 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C6AE")]
		[Address(RVA = "0x2867AF0", Offset = "0x28666F0", VA = "0x182867AF0", Slot = "6")]
		private void OnAfterDeserialize()
		{
		}

		// Token: 0x0602C6AF RID: 181935 RVA: 0x000E00D0 File Offset: 0x000DE2D0
		[Token(Token = "0x602C6AF")]
		[Address(RVA = "0x2867A50", Offset = "0x2866650", VA = "0x182867A50", Slot = "4")]
		private bool ShouldSerialize()
		{
			return default(bool);
		}

		// Token: 0x0602C6B0 RID: 181936 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C6B0")]
		[Address(RVA = "0x2867BE0", Offset = "0x28667E0", VA = "0x182867BE0")]
		public fiDropdownMetadata()
		{
		}

		// Token: 0x040402AA RID: 262826
		[Token(Token = "0x40402AA")]
		[FieldOffset(Offset = "0x10")]
		private fiAnimBool _isActive;

		// Token: 0x040402AB RID: 262827
		[Token(Token = "0x40402AB")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool _showDropdown;

		// Token: 0x040402AC RID: 262828
		[Token(Token = "0x40402AC")]
		[FieldOffset(Offset = "0x19")]
		private bool _invertedDefaultState;

		// Token: 0x040402AD RID: 262829
		[Token(Token = "0x40402AD")]
		[FieldOffset(Offset = "0x1A")]
		private bool _forceDisable;

		// Token: 0x040402AE RID: 262830
		[Token(Token = "0x40402AE")]
		[FieldOffset(Offset = "0x1B")]
		[SerializeField]
		private bool _serializedIsActive;
	}
}
