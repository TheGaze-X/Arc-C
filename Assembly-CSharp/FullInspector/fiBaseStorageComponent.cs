using System;
using System.Collections.Generic;
using FullInspector.Internal;
using Il2CppDummyDll;
using UnityEngine;

namespace FullInspector
{
	// Token: 0x02007BFF RID: 31743
	[Token(Token = "0x2007BFF")]
	[AddComponentMenu("")]
	public abstract class fiBaseStorageComponent<T> : MonoBehaviour, fiIEditorOnlyTag, ISerializationCallbackReceiver
	{
		// Token: 0x1700680A RID: 26634
		// (get) Token: 0x0602C696 RID: 181910 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700680A")]
		public IDictionary<UnityEngine.Object, T> Data
		{
			[Token(Token = "0x602C696")]
			get
			{
				return null;
			}
		}

		// Token: 0x0602C697 RID: 181911 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C697")]
		private void OnAfterDeserialize()
		{
		}

		// Token: 0x0602C698 RID: 181912 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C698")]
		private void OnBeforeSerialize()
		{
		}

		// Token: 0x0602C699 RID: 181913 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C699")]
		protected fiBaseStorageComponent()
		{
		}

		// Token: 0x040402A4 RID: 262820
		[Token(Token = "0x40402A4")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private List<UnityEngine.Object> _keys;

		// Token: 0x040402A5 RID: 262821
		[Token(Token = "0x40402A5")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private List<T> _values;

		// Token: 0x040402A6 RID: 262822
		[Token(Token = "0x40402A6")]
		[FieldOffset(Offset = "0x0")]
		private IDictionary<UnityEngine.Object, T> _data;
	}
}
