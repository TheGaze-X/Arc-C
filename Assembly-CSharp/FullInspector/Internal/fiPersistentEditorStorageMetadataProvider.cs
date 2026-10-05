using System;
using Il2CppDummyDll;

namespace FullInspector.Internal
{
	// Token: 0x02007CBA RID: 31930
	[Token(Token = "0x2007CBA")]
	public abstract class fiPersistentEditorStorageMetadataProvider<TItem, TStorage> : fiIPersistentMetadataProvider where TItem : new() where TStorage : fiIGraphMetadataStorage, new()
	{
		// Token: 0x0602C985 RID: 182661 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C985")]
		public void RestoreData(fiUnityObjectReference target)
		{
		}

		// Token: 0x0602C986 RID: 182662 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C986")]
		public void Reset(fiUnityObjectReference target)
		{
		}

		// Token: 0x17006862 RID: 26722
		// (get) Token: 0x0602C987 RID: 182663 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17006862")]
		public Type MetadataType
		{
			[Token(Token = "0x602C987")]
			get
			{
				return null;
			}
		}

		// Token: 0x0602C988 RID: 182664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C988")]
		protected fiPersistentEditorStorageMetadataProvider()
		{
		}
	}
}
