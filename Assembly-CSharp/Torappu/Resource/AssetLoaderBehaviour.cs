using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Resource
{
	// Token: 0x0200174D RID: 5965
	[Token(Token = "0x200174D")]
	public class AssetLoaderBehaviour : MonoBehaviour
	{
		// Token: 0x17001015 RID: 4117
		// (get) Token: 0x0600965A RID: 38490 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001015")]
		public AbstractAssetLoader internalLoader
		{
			[Token(Token = "0x600965A")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600965B RID: 38491 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600965B")]
		public T Load<T>(string path) where T : UnityEngine.Object
		{
			return null;
		}

		// Token: 0x0600965C RID: 38492 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600965C")]
		[Address(RVA = "0x311F2D0", Offset = "0x311DED0", VA = "0x18311F2D0")]
		public UnityEngine.Object Load(string path)
		{
			return null;
		}

		// Token: 0x0600965D RID: 38493 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600965D")]
		public T[] LoadAll<T>(string path) where T : UnityEngine.Object
		{
			return null;
		}

		// Token: 0x0600965E RID: 38494 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600965E")]
		[Address(RVA = "0x311F270", Offset = "0x311DE70", VA = "0x18311F270")]
		public UnityEngine.Object[] LoadAll(string path)
		{
			return null;
		}

		// Token: 0x0600965F RID: 38495 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600965F")]
		public AsyncResource LoadAsync<T>(string path) where T : UnityEngine.Object
		{
			return null;
		}

		// Token: 0x06009660 RID: 38496 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009660")]
		[Address(RVA = "0x311F290", Offset = "0x311DE90", VA = "0x18311F290")]
		public AsyncResource LoadAsync(string path)
		{
			return null;
		}

		// Token: 0x06009661 RID: 38497 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009661")]
		public void LoadAsync<T>(string path, Action<bool, T> cb) where T : UnityEngine.Object
		{
		}

		// Token: 0x06009662 RID: 38498 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009662")]
		[Address(RVA = "0x311F2B0", Offset = "0x311DEB0", VA = "0x18311F2B0")]
		public void LoadAsync(string path, Action<bool, UnityEngine.Object> cb)
		{
		}

		// Token: 0x06009663 RID: 38499 RVA: 0x0003A950 File Offset: 0x00038B50
		[Token(Token = "0x6009663")]
		public bool TryLoad<T>(string path, out T obj) where T : UnityEngine.Object
		{
			return default(bool);
		}

		// Token: 0x06009664 RID: 38500 RVA: 0x0003A968 File Offset: 0x00038B68
		[Token(Token = "0x6009664")]
		[Address(RVA = "0x311F2F0", Offset = "0x311DEF0", VA = "0x18311F2F0")]
		public bool TryLoad(string path, out UnityEngine.Object obj)
		{
			return default(bool);
		}

		// Token: 0x06009665 RID: 38501 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009665")]
		[Address(RVA = "0x311F310", Offset = "0x311DF10", VA = "0x18311F310")]
		public void Unload(UnityEngine.Object asset)
		{
		}

		// Token: 0x06009666 RID: 38502 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009666")]
		[Address(RVA = "0x311F230", Offset = "0x311DE30", VA = "0x18311F230")]
		public void ClearAll()
		{
		}

		// Token: 0x06009667 RID: 38503 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009667")]
		[Address(RVA = "0x311F190", Offset = "0x311DD90", VA = "0x18311F190")]
		private void Awake()
		{
		}

		// Token: 0x06009668 RID: 38504 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009668")]
		[Address(RVA = "0x311F230", Offset = "0x311DE30", VA = "0x18311F230")]
		private void OnDestroy()
		{
		}

		// Token: 0x06009669 RID: 38505 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009669")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public AssetLoaderBehaviour()
		{
		}

		// Token: 0x04008CA8 RID: 36008
		[Token(Token = "0x4008CA8")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool m_cached;

		// Token: 0x04008CA9 RID: 36009
		[Token(Token = "0x4008CA9")]
		[FieldOffset(Offset = "0x20")]
		private AbstractAssetLoader m_assetLoader;
	}
}
