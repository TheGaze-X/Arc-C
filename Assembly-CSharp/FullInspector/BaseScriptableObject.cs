using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FullInspector.Internal;
using Il2CppDummyDll;
using UnityEngine;

namespace FullInspector
{
	// Token: 0x02007BBC RID: 31676
	[Token(Token = "0x2007BBC")]
	public abstract class BaseScriptableObject<TSerializer> : CommonBaseScriptableObject, ISerializedObject, ISerializationCallbackReceiver where TSerializer : BaseSerializer
	{
		// Token: 0x0602C547 RID: 181575 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C547")]
		protected virtual void OnEnable()
		{
		}

		// Token: 0x0602C548 RID: 181576 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C548")]
		protected virtual void OnValidate()
		{
		}

		// Token: 0x0602C549 RID: 181577 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C549")]
		[ContextMenu("Save Current State")]
		public void SaveState()
		{
		}

		// Token: 0x0602C54A RID: 181578 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C54A")]
		[ContextMenu("Restore Saved State")]
		public void RestoreState()
		{
		}

		// Token: 0x170067C2 RID: 26562
		// (get) Token: 0x0602C54B RID: 181579 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602C54C RID: 181580 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170067C2")]
		private List<UnityEngine.Object> SerializedObjectReferences
		{
			[Token(Token = "0x602C54B")]
			get
			{
				return null;
			}
			[Token(Token = "0x602C54C")]
			set
			{
			}
		}

		// Token: 0x170067C3 RID: 26563
		// (get) Token: 0x0602C54D RID: 181581 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602C54E RID: 181582 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170067C3")]
		private List<string> SerializedStateKeys
		{
			[Token(Token = "0x602C54D")]
			get
			{
				return null;
			}
			[Token(Token = "0x602C54E")]
			set
			{
			}
		}

		// Token: 0x170067C4 RID: 26564
		// (get) Token: 0x0602C54F RID: 181583 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602C550 RID: 181584 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170067C4")]
		private List<string> SerializedStateValues
		{
			[Token(Token = "0x602C54F")]
			get
			{
				return null;
			}
			[Token(Token = "0x602C550")]
			set
			{
			}
		}

		// Token: 0x170067C5 RID: 26565
		// (get) Token: 0x0602C551 RID: 181585 RVA: 0x000DF938 File Offset: 0x000DDB38
		// (set) Token: 0x0602C552 RID: 181586 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170067C5")]
		private bool IsRestored
		{
			[Token(Token = "0x602C551")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x602C552")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0602C553 RID: 181587 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C553")]
		private void OnAfterDeserialize()
		{
		}

		// Token: 0x0602C554 RID: 181588 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C554")]
		private void OnBeforeSerialize()
		{
		}

		// Token: 0x0602C555 RID: 181589 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C555")]
		protected BaseScriptableObject()
		{
		}

		// Token: 0x04040210 RID: 262672
		[Token(Token = "0x4040210")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		[NotSerialized]
		[HideInInspector]
		private List<UnityEngine.Object> _objectReferences;

		// Token: 0x04040211 RID: 262673
		[Token(Token = "0x4040211")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		[NotSerialized]
		[HideInInspector]
		private List<string> _serializedStateKeys;

		// Token: 0x04040212 RID: 262674
		[Token(Token = "0x4040212")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		[NotSerialized]
		[HideInInspector]
		private List<string> _serializedStateValues;
	}
}
