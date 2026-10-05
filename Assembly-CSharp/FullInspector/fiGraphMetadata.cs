using System;
using System.Collections.Generic;
using FullInspector.Internal;
using Il2CppDummyDll;
using UnityEngine;

namespace FullInspector
{
	// Token: 0x02007BC1 RID: 31681
	[Token(Token = "0x2007BC1")]
	public class fiGraphMetadata
	{
		// Token: 0x0602C55C RID: 181596 RVA: 0x000DF968 File Offset: 0x000DDB68
		[Token(Token = "0x602C55C")]
		[Address(RVA = "0x2869260", Offset = "0x2867E60", VA = "0x182869260")]
		public bool ShouldSerialize()
		{
			return default(bool);
		}

		// Token: 0x0602C55D RID: 181597 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C55D")]
		public void Serialize<TPersistentData>(out string[] keys_, out TPersistentData[] values_) where TPersistentData : IGraphMetadataItemPersistent
		{
		}

		// Token: 0x0602C55E RID: 181598 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C55E")]
		private void AddSerializeData<TPersistentData>(List<string> keys, List<TPersistentData> values) where TPersistentData : IGraphMetadataItemPersistent
		{
		}

		// Token: 0x0602C55F RID: 181599 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C55F")]
		public void Deserialize<TPersistentData>(string[] keys, TPersistentData[] values)
		{
		}

		// Token: 0x0602C560 RID: 181600 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C560")]
		[Address(RVA = "0x2868D70", Offset = "0x2867970", VA = "0x182868D70")]
		public void BeginCullZone()
		{
		}

		// Token: 0x0602C561 RID: 181601 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C561")]
		[Address(RVA = "0x2868E00", Offset = "0x2867A00", VA = "0x182868E00")]
		public void EndCullZone()
		{
		}

		// Token: 0x170067C7 RID: 26567
		// (get) Token: 0x0602C562 RID: 181602 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170067C7")]
		private UnityEngine.Object TargetObject
		{
			[Token(Token = "0x602C562")]
			[Address(RVA = "0x28696F0", Offset = "0x28682F0", VA = "0x1828696F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170067C8 RID: 26568
		// (get) Token: 0x0602C563 RID: 181603 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170067C8")]
		public string Path
		{
			[Token(Token = "0x602C563")]
			[Address(RVA = "0x4EE950", Offset = "0x4ED550", VA = "0x1804EE950")]
			get
			{
				return null;
			}
		}

		// Token: 0x0602C564 RID: 181604 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C564")]
		[Address(RVA = "0x28692E0", Offset = "0x2867EE0", VA = "0x1828692E0")]
		public fiGraphMetadata()
		{
		}

		// Token: 0x0602C565 RID: 181605 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C565")]
		[Address(RVA = "0x2869680", Offset = "0x2868280", VA = "0x182869680")]
		public fiGraphMetadata(fiUnityObjectReference targetObject)
		{
		}

		// Token: 0x0602C566 RID: 181606 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C566")]
		[Address(RVA = "0x2869340", Offset = "0x2867F40", VA = "0x182869340")]
		private fiGraphMetadata(fiGraphMetadata parentMetadata, string accessKey)
		{
		}

		// Token: 0x0602C567 RID: 181607 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C567")]
		[Address(RVA = "0x2869080", Offset = "0x2867C80", VA = "0x182869080")]
		private void RebuildAccessPath(string accessKey)
		{
		}

		// Token: 0x0602C568 RID: 181608 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C568")]
		[Address(RVA = "0x28691E0", Offset = "0x2867DE0", VA = "0x1828691E0")]
		public void SetChild(int identifier, fiGraphMetadata metadata)
		{
		}

		// Token: 0x0602C569 RID: 181609 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C569")]
		[Address(RVA = "0x2869160", Offset = "0x2867D60", VA = "0x182869160")]
		public void SetChild(string identifier, fiGraphMetadata metadata)
		{
		}

		// Token: 0x0602C56A RID: 181610 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C56A")]
		public static void MigrateMetadata<T>(fiGraphMetadata metadata, T[] previous, T[] updated)
		{
		}

		// Token: 0x0602C56B RID: 181611 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C56B")]
		private static List<fiGraphMetadata.MetadataMigration> ComputeNeededMigrations<T>(fiGraphMetadata metadata, T[] previous, T[] updated)
		{
			return null;
		}

		// Token: 0x0602C56C RID: 181612 RVA: 0x000DF980 File Offset: 0x000DDB80
		[Token(Token = "0x602C56C")]
		[Address(RVA = "0x2868F80", Offset = "0x2867B80", VA = "0x182868F80")]
		public fiGraphMetadataChild Enter(int childIdentifier)
		{
			return default(fiGraphMetadataChild);
		}

		// Token: 0x0602C56D RID: 181613 RVA: 0x000DF998 File Offset: 0x000DDB98
		[Token(Token = "0x602C56D")]
		[Address(RVA = "0x2868E90", Offset = "0x2867A90", VA = "0x182868E90")]
		public fiGraphMetadataChild Enter(string childIdentifier)
		{
			return default(fiGraphMetadataChild);
		}

		// Token: 0x0602C56E RID: 181614 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C56E")]
		public T GetPersistentMetadata<T>() where T : IGraphMetadataItemPersistent, new()
		{
			return null;
		}

		// Token: 0x0602C56F RID: 181615 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C56F")]
		public T GetPersistentMetadata<T>(out bool wasCreated) where T : IGraphMetadataItemPersistent, new()
		{
			return null;
		}

		// Token: 0x0602C570 RID: 181616 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C570")]
		public T GetMetadata<T>() where T : IGraphMetadataItemNotPersistent, new()
		{
			return null;
		}

		// Token: 0x0602C571 RID: 181617 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C571")]
		public T GetMetadata<T>(out bool wasCreated) where T : IGraphMetadataItemNotPersistent, new()
		{
			return null;
		}

		// Token: 0x0602C572 RID: 181618 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C572")]
		private T GetCommonMetadata<T>(out bool wasCreated) where T : new()
		{
			return null;
		}

		// Token: 0x0602C573 RID: 181619 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C573")]
		public T GetInheritedMetadata<T>() where T : IGraphMetadataItemNotPersistent, new()
		{
			return null;
		}

		// Token: 0x0602C574 RID: 181620 RVA: 0x000DF9B0 File Offset: 0x000DDBB0
		[Token(Token = "0x602C574")]
		public bool TryGetMetadata<T>(out T metadata) where T : IGraphMetadataItemNotPersistent, new()
		{
			return default(bool);
		}

		// Token: 0x0602C575 RID: 181621 RVA: 0x000DF9C8 File Offset: 0x000DDBC8
		[Token(Token = "0x602C575")]
		public bool TryGetInheritedMetadata<T>(out T metadata) where T : IGraphMetadataItemNotPersistent, new()
		{
			return default(bool);
		}

		// Token: 0x04040215 RID: 262677
		[Token(Token = "0x4040215")]
		[FieldOffset(Offset = "0x10")]
		private Dictionary<string, List<object>> _precomputedData;

		// Token: 0x04040216 RID: 262678
		[Token(Token = "0x4040216")]
		[FieldOffset(Offset = "0x18")]
		[ShowInInspector]
		private CullableDictionary<int, fiGraphMetadata, IntDictionary<fiGraphMetadata>> _childrenInt;

		// Token: 0x04040217 RID: 262679
		[Token(Token = "0x4040217")]
		[FieldOffset(Offset = "0x20")]
		[ShowInInspector]
		private CullableDictionary<string, fiGraphMetadata, Dictionary<string, fiGraphMetadata>> _childrenString;

		// Token: 0x04040218 RID: 262680
		[Token(Token = "0x4040218")]
		[FieldOffset(Offset = "0x28")]
		[ShowInInspector]
		private CullableDictionary<Type, object, Dictionary<Type, object>> _metadata;

		// Token: 0x04040219 RID: 262681
		[Token(Token = "0x4040219")]
		[FieldOffset(Offset = "0x30")]
		private fiGraphMetadata _parentMetadata;

		// Token: 0x0404021A RID: 262682
		[Token(Token = "0x404021A")]
		[FieldOffset(Offset = "0x38")]
		private fiUnityObjectReference _targetObject;

		// Token: 0x0404021B RID: 262683
		[Token(Token = "0x404021B")]
		[FieldOffset(Offset = "0x40")]
		private string _accessPath;

		// Token: 0x02007BC2 RID: 31682
		[Token(Token = "0x2007BC2")]
		public struct MetadataMigration
		{
			// Token: 0x0404021C RID: 262684
			[Token(Token = "0x404021C")]
			[FieldOffset(Offset = "0x0")]
			public int NewIndex;

			// Token: 0x0404021D RID: 262685
			[Token(Token = "0x404021D")]
			[FieldOffset(Offset = "0x4")]
			public int OldIndex;
		}
	}
}
