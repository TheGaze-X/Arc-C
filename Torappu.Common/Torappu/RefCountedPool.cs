using System;
using System.Collections.Generic;
using Hypergryph.ToolKits;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020000A6 RID: 166
	[Token(Token = "0x20000A6")]
	public abstract class RefCountedPool<TItem, TObject> where TItem : RefCountedPoolItem<TObject>, new() where TObject : class
	{
		// Token: 0x06000414 RID: 1044 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000414")]
		public TItem Load(string key, string persistTag)
		{
			return null;
		}

		// Token: 0x06000415 RID: 1045 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000415")]
		public TItem Find(string key)
		{
			return null;
		}

		// Token: 0x06000416 RID: 1046 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000416")]
		private void _SetPersistTagImpl(TItem item, string persistTag)
		{
		}

		// Token: 0x06000417 RID: 1047 RVA: 0x000052AC File Offset: 0x000034AC
		[Token(Token = "0x6000417")]
		public bool SetMaxRefAllowed(string key, int maxRefAllowed)
		{
			return default(bool);
		}

		// Token: 0x06000418 RID: 1048 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000418")]
		public void UnloadByRef(string key)
		{
		}

		// Token: 0x06000419 RID: 1049 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000419")]
		public void ForceUnload(string key)
		{
		}

		// Token: 0x0600041A RID: 1050 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x600041A")]
		public void FindItemsWithPersistTag(string persistTag, ICollection<TItem> output)
		{
		}

		// Token: 0x0600041B RID: 1051 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600041B")]
		public List<TItem> InspectLoadedItems()
		{
			return null;
		}

		// Token: 0x0600041C RID: 1052 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x600041C")]
		private void _ReleaseItem(TItem item)
		{
		}

		// Token: 0x0600041D RID: 1053
		[Token(Token = "0x600041D")]
		protected abstract bool LoadObjectToItem(TItem item);

		// Token: 0x0600041E RID: 1054
		[Token(Token = "0x600041E")]
		protected abstract void ReleaseObject(TItem item);

		// Token: 0x0600041F RID: 1055 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x600041F")]
		protected virtual void OnPersistTagChangedSubClass(TItem item)
		{
		}

		// Token: 0x06000420 RID: 1056 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000420")]
		protected RefCountedPool()
		{
		}

		// Token: 0x0400043B RID: 1083
		[Token(Token = "0x400043B")]
		[FieldOffset(Offset = "0x0")]
		private LocalGenericPool<TItem> m_itemPool;

		// Token: 0x0400043C RID: 1084
		[Token(Token = "0x400043C")]
		[FieldOffset(Offset = "0x0")]
		private Dictionary<string, TItem> m_loadedItems;
	}
}
