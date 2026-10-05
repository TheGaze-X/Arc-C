using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FullInspector.Internal;
using Il2CppDummyDll;
using UnityEngine;

namespace FullInspector
{
	// Token: 0x02007BBA RID: 31674
	[Token(Token = "0x2007BBA")]
	public abstract class BaseBehavior<TSerializer> : CommonBaseBehavior, ISerializedObject, ISerializationCallbackReceiver where TSerializer : BaseSerializer
	{
		// Token: 0x0602C527 RID: 181543 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C527")]
		protected virtual void Awake()
		{
		}

		// Token: 0x0602C528 RID: 181544 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C528")]
		protected virtual void OnValidate()
		{
		}

		// Token: 0x0602C529 RID: 181545 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C529")]
		[ContextMenu("Save Current State")]
		public void SaveState()
		{
		}

		// Token: 0x0602C52A RID: 181546 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C52A")]
		[ContextMenu("Restore Saved State")]
		public void RestoreState()
		{
		}

		// Token: 0x170067BA RID: 26554
		// (get) Token: 0x0602C52B RID: 181547 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602C52C RID: 181548 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170067BA")]
		private List<UnityEngine.Object> SerializedObjectReferences
		{
			[Token(Token = "0x602C52B")]
			get
			{
				return null;
			}
			[Token(Token = "0x602C52C")]
			set
			{
			}
		}

		// Token: 0x170067BB RID: 26555
		// (get) Token: 0x0602C52D RID: 181549 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602C52E RID: 181550 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170067BB")]
		private List<string> SerializedStateKeys
		{
			[Token(Token = "0x602C52D")]
			get
			{
				return null;
			}
			[Token(Token = "0x602C52E")]
			set
			{
			}
		}

		// Token: 0x170067BC RID: 26556
		// (get) Token: 0x0602C52F RID: 181551 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602C530 RID: 181552 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170067BC")]
		private List<string> SerializedStateValues
		{
			[Token(Token = "0x602C52F")]
			get
			{
				return null;
			}
			[Token(Token = "0x602C530")]
			set
			{
			}
		}

		// Token: 0x170067BD RID: 26557
		// (get) Token: 0x0602C531 RID: 181553 RVA: 0x000DF908 File Offset: 0x000DDB08
		// (set) Token: 0x0602C532 RID: 181554 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170067BD")]
		private bool IsRestored
		{
			[Token(Token = "0x602C531")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x602C532")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0602C533 RID: 181555 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C533")]
		private void OnAfterDeserialize()
		{
		}

		// Token: 0x0602C534 RID: 181556 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C534")]
		private void OnBeforeSerialize()
		{
		}

		// Token: 0x0602C535 RID: 181557 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C535")]
		protected BaseBehavior()
		{
		}

		// Token: 0x04040208 RID: 262664
		[Token(Token = "0x4040208")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		[NotSerialized]
		[HideInInspector]
		private List<UnityEngine.Object> _objectReferences;

		// Token: 0x04040209 RID: 262665
		[Token(Token = "0x4040209")]
		[FieldOffset(Offset = "0x0")]
		[HideInInspector]
		[SerializeField]
		[NotSerialized]
		private List<string> _serializedStateKeys;

		// Token: 0x0404020A RID: 262666
		[Token(Token = "0x404020A")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		[NotSerialized]
		[HideInInspector]
		private List<string> _serializedStateValues;
	}
}
