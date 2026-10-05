using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FullInspector.Internal;
using Il2CppDummyDll;
using UnityEngine;

namespace FullInspector
{
	// Token: 0x02007BBB RID: 31675
	[Token(Token = "0x2007BBB")]
	public abstract class BaseNetworkBehavior : CommonBaseNetworkBehavior, ISerializedObject, ISerializationCallbackReceiver
	{
		// Token: 0x0602C537 RID: 181559 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C537")]
		[Address(RVA = "0x2853CD0", Offset = "0x28528D0", VA = "0x182853CD0", Slot = "16")]
		protected virtual void Awake()
		{
		}

		// Token: 0x0602C538 RID: 181560 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C538")]
		[Address(RVA = "0x2853D30", Offset = "0x2852930", VA = "0x182853D30", Slot = "17")]
		protected virtual void OnValidate()
		{
		}

		// Token: 0x0602C539 RID: 181561 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C539")]
		[Address(RVA = "0x2853DF0", Offset = "0x28529F0", VA = "0x182853DF0", Slot = "5")]
		[ContextMenu("Save Current State")]
		public void SaveState()
		{
		}

		// Token: 0x0602C53A RID: 181562 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C53A")]
		[Address(RVA = "0x2853DB0", Offset = "0x28529B0", VA = "0x182853DB0", Slot = "4")]
		[ContextMenu("Restore Saved State")]
		public void RestoreState()
		{
		}

		// Token: 0x170067BE RID: 26558
		// (get) Token: 0x0602C53B RID: 181563 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602C53C RID: 181564 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170067BE")]
		private List<UnityEngine.Object> SerializedObjectReferences
		{
			[Token(Token = "0x602C53B")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80", Slot = "8")]
			get
			{
				return null;
			}
			[Token(Token = "0x602C53C")]
			[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670", Slot = "9")]
			set
			{
			}
		}

		// Token: 0x170067BF RID: 26559
		// (get) Token: 0x0602C53D RID: 181565 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602C53E RID: 181566 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170067BF")]
		private List<string> SerializedStateKeys
		{
			[Token(Token = "0x602C53D")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70", Slot = "10")]
			get
			{
				return null;
			}
			[Token(Token = "0x602C53E")]
			[Address(RVA = "0x4E6EC0", Offset = "0x4E5AC0", VA = "0x1804E6EC0", Slot = "11")]
			set
			{
			}
		}

		// Token: 0x170067C0 RID: 26560
		// (get) Token: 0x0602C53F RID: 181567 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602C540 RID: 181568 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170067C0")]
		private List<string> SerializedStateValues
		{
			[Token(Token = "0x602C53F")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070", Slot = "12")]
			get
			{
				return null;
			}
			[Token(Token = "0x602C540")]
			[Address(RVA = "0x4E6EB0", Offset = "0x4E5AB0", VA = "0x1804E6EB0", Slot = "13")]
			set
			{
			}
		}

		// Token: 0x170067C1 RID: 26561
		// (get) Token: 0x0602C541 RID: 181569 RVA: 0x000DF920 File Offset: 0x000DDB20
		// (set) Token: 0x0602C542 RID: 181570 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170067C1")]
		private bool IsRestored
		{
			[Token(Token = "0x602C541")]
			[Address(RVA = "0xAE5EF0", Offset = "0xAE4AF0", VA = "0x180AE5EF0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x602C542")]
			[Address(RVA = "0x17F30F0", Offset = "0x17F1CF0", VA = "0x1817F30F0", Slot = "7")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0602C543 RID: 181571 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C543")]
		[Address(RVA = "0x2853E30", Offset = "0x2852A30", VA = "0x182853E30", Slot = "15")]
		private void OnAfterDeserialize()
		{
		}

		// Token: 0x0602C544 RID: 181572 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C544")]
		[Address(RVA = "0x2853F40", Offset = "0x2852B40", VA = "0x182853F40", Slot = "14")]
		private void OnBeforeSerialize()
		{
		}

		// Token: 0x0602C545 RID: 181573 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C545")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		protected BaseNetworkBehavior()
		{
		}

		// Token: 0x0404020C RID: 262668
		[Token(Token = "0x404020C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[NotSerialized]
		[HideInInspector]
		private List<UnityEngine.Object> _objectReferences;

		// Token: 0x0404020D RID: 262669
		[Token(Token = "0x404020D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[NotSerialized]
		[HideInInspector]
		private List<string> _serializedStateKeys;

		// Token: 0x0404020E RID: 262670
		[Token(Token = "0x404020E")]
		[FieldOffset(Offset = "0x28")]
		[NotSerialized]
		[HideInInspector]
		[SerializeField]
		private List<string> _serializedStateValues;
	}
}
