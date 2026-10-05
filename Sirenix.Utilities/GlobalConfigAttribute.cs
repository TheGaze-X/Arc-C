using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Sirenix.Utilities
{
	// Token: 0x0200006B RID: 107
	[Token(Token = "0x200006B")]
	[AttributeUsage(AttributeTargets.Class)]
	public class GlobalConfigAttribute : Attribute
	{
		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060002BC RID: 700 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x17000045")]
		[Obsolete("It's a bit more complicated than that as it's not always possible to know the full path, so try and make due without it if you can, only using the AssetDatabase.")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public string FullPath
		{
			[Token(Token = "0x60002BC")]
			[Address(RVA = "0x4E23B40", Offset = "0x4E22740", VA = "0x184E23B40")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x060002BD RID: 701 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x17000046")]
		public string AssetPath
		{
			[Token(Token = "0x60002BD")]
			[Address(RVA = "0x4E23A10", Offset = "0x4E22610", VA = "0x184E23A10")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x060002BE RID: 702 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x17000047")]
		internal string AssetPathWithAssetsPrefix
		{
			[Token(Token = "0x60002BE")]
			[Address(RVA = "0x4E23910", Offset = "0x4E22510", VA = "0x184E23910")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x060002BF RID: 703 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x17000048")]
		internal string AssetPathWithoutAssetsPrefix
		{
			[Token(Token = "0x60002BF")]
			[Address(RVA = "0x4E23990", Offset = "0x4E22590", VA = "0x184E23990")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x060002C0 RID: 704 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x17000049")]
		public string ResourcesPath
		{
			[Token(Token = "0x60002C0")]
			[Address(RVA = "0x4E23C00", Offset = "0x4E22800", VA = "0x184E23C00")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x060002C1 RID: 705 RVA: 0x0000314C File Offset: 0x0000134C
		// (set) Token: 0x060002C2 RID: 706 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700004A")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("This option is obsolete and will have no effect - a GlobalConfig will always have an asset generated now; use a POCO singleton or a ScriptableSingleton<T> instead. Asset-less config objects that are recreated every reload cause UnityEngine.Object leaks.", true)]
		public bool UseAsset
		{
			[Token(Token = "0x60002C1")]
			[Address(RVA = "0x4F4E70", Offset = "0x4F3A70", VA = "0x1804F4E70")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002C2")]
			[Address(RVA = "0x4F4E80", Offset = "0x4F3A80", VA = "0x1804F4E80")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x060002C3 RID: 707 RVA: 0x00003164 File Offset: 0x00001364
		[Token(Token = "0x1700004B")]
		public bool IsInResourcesFolder
		{
			[Token(Token = "0x60002C3")]
			[Address(RVA = "0x4E23BA0", Offset = "0x4E227A0", VA = "0x184E23BA0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060002C4 RID: 708 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60002C4")]
		[Address(RVA = "0x4E238B0", Offset = "0x4E224B0", VA = "0x184E238B0")]
		public GlobalConfigAttribute()
		{
		}

		// Token: 0x060002C5 RID: 709 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60002C5")]
		[Address(RVA = "0x50BD60", Offset = "0x50A960", VA = "0x18050BD60")]
		public GlobalConfigAttribute(string assetPath)
		{
		}

		// Token: 0x0400019D RID: 413
		[Token(Token = "0x400019D")]
		[FieldOffset(Offset = "0x10")]
		private string assetPath;
	}
}
