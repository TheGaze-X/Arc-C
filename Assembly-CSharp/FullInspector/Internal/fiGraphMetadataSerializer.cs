using System;
using Il2CppDummyDll;
using UnityEngine;

namespace FullInspector.Internal
{
	// Token: 0x02007CB7 RID: 31927
	[Token(Token = "0x2007CB7")]
	public class fiGraphMetadataSerializer<TPersistentData> : fiIGraphMetadataStorage, ISerializationCallbackReceiver where TPersistentData : IGraphMetadataItemPersistent
	{
		// Token: 0x0602C979 RID: 182649 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C979")]
		public void RestoreData(fiUnityObjectReference target)
		{
		}

		// Token: 0x0602C97A RID: 182650 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C97A")]
		private void OnAfterDeserialize()
		{
		}

		// Token: 0x0602C97B RID: 182651 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C97B")]
		private void OnBeforeSerialize()
		{
		}

		// Token: 0x0602C97C RID: 182652 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C97C")]
		public fiGraphMetadataSerializer()
		{
		}

		// Token: 0x040403DF RID: 263135
		[Token(Token = "0x40403DF")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private string[] _keys;

		// Token: 0x040403E0 RID: 263136
		[Token(Token = "0x40403E0")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private TPersistentData[] _values;

		// Token: 0x040403E1 RID: 263137
		[Token(Token = "0x40403E1")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private UnityEngine.Object _target;
	}
}
