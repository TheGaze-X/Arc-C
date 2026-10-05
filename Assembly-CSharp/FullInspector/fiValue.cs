using System;
using System.Collections.Generic;
using FullInspector.Internal;
using Il2CppDummyDll;
using UnityEngine;

namespace FullInspector
{
	// Token: 0x02007BFC RID: 31740
	[Token(Token = "0x2007BFC")]
	public abstract class fiValue<T> : fiValueProxyEditor, fiIValueProxyAPI, ISerializationCallbackReceiver
	{
		// Token: 0x0602C68A RID: 181898 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C68A")]
		private void OnBeforeSerialize()
		{
		}

		// Token: 0x0602C68B RID: 181899 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C68B")]
		private void OnAfterDeserialize()
		{
		}

		// Token: 0x17006809 RID: 26633
		// (get) Token: 0x0602C68C RID: 181900 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602C68D RID: 181901 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006809")]
		private object Value
		{
			[Token(Token = "0x602C68C")]
			get
			{
				return null;
			}
			[Token(Token = "0x602C68D")]
			set
			{
			}
		}

		// Token: 0x0602C68E RID: 181902 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C68E")]
		private void SaveState()
		{
		}

		// Token: 0x0602C68F RID: 181903 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C68F")]
		private void LoadState()
		{
		}

		// Token: 0x0602C690 RID: 181904 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C690")]
		private void Serialize()
		{
		}

		// Token: 0x0602C691 RID: 181905 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C691")]
		private void Deserialize()
		{
		}

		// Token: 0x0602C692 RID: 181906 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C692")]
		protected fiValue()
		{
		}

		// Token: 0x0404029E RID: 262814
		[Token(Token = "0x404029E")]
		[FieldOffset(Offset = "0x0")]
		public T Value;

		// Token: 0x0404029F RID: 262815
		[Token(Token = "0x404029F")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		[HideInInspector]
		private string SerializedState;

		// Token: 0x040402A0 RID: 262816
		[Token(Token = "0x40402A0")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		[HideInInspector]
		private List<UnityEngine.Object> SerializedObjectReferences;

		// Token: 0x02007BFD RID: 31741
		[Token(Token = "0x2007BFD")]
		private class DeserializeAction
		{
			// Token: 0x0602C693 RID: 181907 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602C693")]
			public static T Invoke(fiValue<T> target, FullSerializerSerializer serializer, string state, ListSerializationOperator opt)
			{
				return null;
			}

			// Token: 0x0602C694 RID: 181908 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602C694")]
			public DeserializeAction()
			{
			}
		}
	}
}
