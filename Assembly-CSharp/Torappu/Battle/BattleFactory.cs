using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Torappu.Battle.Effects;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020023EF RID: 9199
	[Token(Token = "0x20023EF")]
	public class BattleFactory : MonoBehaviour, ILuaCallCSharp, IHotfixable
	{
		// Token: 0x17001DF8 RID: 7672
		// (get) Token: 0x0600EAFC RID: 60156 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001DF8")]
		public Transform projectileFolder
		{
			[Token(Token = "0x600EAFC")]
			[Address(RVA = "0x607D30", Offset = "0x606930", VA = "0x180607D30")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001DF9 RID: 7673
		// (get) Token: 0x0600EAFD RID: 60157 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001DF9")]
		public Transform effectFolder
		{
			[Token(Token = "0x600EAFD")]
			[Address(RVA = "0x607C30", Offset = "0x606830", VA = "0x180607C30")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001DFA RID: 7674
		// (get) Token: 0x0600EAFE RID: 60158 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001DFA")]
		public Transform characterFolder
		{
			[Token(Token = "0x600EAFE")]
			[Address(RVA = "0x607BD0", Offset = "0x6067D0", VA = "0x180607BD0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001DFB RID: 7675
		// (get) Token: 0x0600EAFF RID: 60159 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001DFB")]
		public Transform mapWidgetFolder
		{
			[Token(Token = "0x600EAFF")]
			[Address(RVA = "0x607C90", Offset = "0x606890", VA = "0x180607C90")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600EB00 RID: 60160 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600EB00")]
		[Address(RVA = "0x606130", Offset = "0x604D30", VA = "0x180606130")]
		public CameraController CreateCamera(bool needPostprocess)
		{
			return null;
		}

		// Token: 0x0600EB01 RID: 60161 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600EB01")]
		[Address(RVA = "0x605F70", Offset = "0x604B70", VA = "0x180605F70")]
		public Camera CreateCameraWithoutController(Transform controllerOffset)
		{
			return null;
		}

		// Token: 0x0600EB02 RID: 60162 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600EB02")]
		[Address(RVA = "0x606D60", Offset = "0x605960", VA = "0x180606D60")]
		public PreviewCursor CreatePreviewCursor(MotionMode motionMode)
		{
			return null;
		}

		// Token: 0x0600EB03 RID: 60163 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600EB03")]
		[Address(RVA = "0x6067D0", Offset = "0x6053D0", VA = "0x1806067D0")]
		public Enemy CreateEnemy(string enemyKey)
		{
			return null;
		}

		// Token: 0x0600EB04 RID: 60164 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600EB04")]
		[Address(RVA = "0x606310", Offset = "0x604F10", VA = "0x180606310")]
		public Character CreateCharacter(BattleCharacterData data)
		{
			return null;
		}

		// Token: 0x0600EB05 RID: 60165 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600EB05")]
		[Address(RVA = "0x607620", Offset = "0x606220", VA = "0x180607620")]
		public Character CreateToken(BattleCharacterData data)
		{
			return null;
		}

		// Token: 0x0600EB06 RID: 60166 RVA: 0x000560D0 File Offset: 0x000542D0
		[Token(Token = "0x600EB06")]
		[Address(RVA = "0x607810", Offset = "0x606410", VA = "0x180607810")]
		public bool TouchCharacter(BattleCharacterData data, Action<Character> cb)
		{
			return default(bool);
		}

		// Token: 0x0600EB07 RID: 60167 RVA: 0x000560E8 File Offset: 0x000542E8
		[Token(Token = "0x600EB07")]
		[Address(RVA = "0x6079C0", Offset = "0x6065C0", VA = "0x1806079C0")]
		public bool TouchToken(BattleCharacterData data, Action<Character> cb)
		{
			return default(bool);
		}

		// Token: 0x0600EB08 RID: 60168 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600EB08")]
		[Address(RVA = "0x606F90", Offset = "0x605B90", VA = "0x180606F90")]
		public Projectile CreateProjectile(string projectileKey)
		{
			return null;
		}

		// Token: 0x0600EB09 RID: 60169 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600EB09")]
		[Address(RVA = "0x607160", Offset = "0x605D60", VA = "0x180607160")]
		public BasicSkill CreateSkill(string skillKey)
		{
			return null;
		}

		// Token: 0x0600EB0A RID: 60170 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600EB0A")]
		[Address(RVA = "0x6072A0", Offset = "0x605EA0", VA = "0x1806072A0")]
		public UnitAnimator CreateSkin(SkinType skinType, string skinId, [Optional] string charId, [Optional] string tmpId)
		{
			return null;
		}

		// Token: 0x0600EB0B RID: 60171 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600EB0B")]
		[Address(RVA = "0x606640", Offset = "0x605240", VA = "0x180606640")]
		public Effect CreateEffect(string effectKey)
		{
			return null;
		}

		// Token: 0x0600EB0C RID: 60172 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600EB0C")]
		[Address(RVA = "0x605E70", Offset = "0x604A70", VA = "0x180605E70")]
		public CameraEffect CreateCameraEffect(string effectKey)
		{
			return null;
		}

		// Token: 0x0600EB0D RID: 60173 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600EB0D")]
		[Address(RVA = "0x6069A0", Offset = "0x6055A0", VA = "0x1806069A0")]
		public GlobalBuff CreateGlobalBuff(string globalBuffKey)
		{
			return null;
		}

		// Token: 0x0600EB0E RID: 60174 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600EB0E")]
		[Address(RVA = "0x606BE0", Offset = "0x6057E0", VA = "0x180606BE0")]
		public GlobalEnvSystem CreateGlobalEnvSystem(string envSystemKey)
		{
			return null;
		}

		// Token: 0x0600EB0F RID: 60175 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600EB0F")]
		[Address(RVA = "0x6073D0", Offset = "0x605FD0", VA = "0x1806073D0")]
		public Tile CreateTile(string tileKey, Transform container)
		{
			return null;
		}

		// Token: 0x0600EB10 RID: 60176 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600EB10")]
		[Address(RVA = "0x605C20", Offset = "0x604820", VA = "0x180605C20")]
		public BlockedEdge CreateBlockedEdge(string edgeKey, Transform container)
		{
			return null;
		}

		// Token: 0x0600EB11 RID: 60177 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600EB11")]
		[Address(RVA = "0x606500", Offset = "0x605100", VA = "0x180606500")]
		public Ability CreateDynamicAbility(string abilityKey)
		{
			return null;
		}

		// Token: 0x0600EB12 RID: 60178 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600EB12")]
		[Address(RVA = "0x6059F0", Offset = "0x6045F0", VA = "0x1806059F0")]
		public Ability AttachEquipIfNot(string equipResKey, Transform parent, string equipKey, out string equipOriginName)
		{
			return null;
		}

		// Token: 0x0600EB13 RID: 60179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EB13")]
		[Address(RVA = "0x607B70", Offset = "0x606770", VA = "0x180607B70")]
		public BattleFactory()
		{
		}

		// Token: 0x0401037B RID: 66427
		[Token(Token = "0x401037B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private PreviewCursor _walkCursor;

		// Token: 0x0401037C RID: 66428
		[Token(Token = "0x401037C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private PreviewCursor _flyCursor;

		// Token: 0x0401037D RID: 66429
		[Token(Token = "0x401037D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform _enemyFolder;

		// Token: 0x0401037E RID: 66430
		[Token(Token = "0x401037E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Transform _characterFolder;

		// Token: 0x0401037F RID: 66431
		[Token(Token = "0x401037F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Transform _miscFolder;

		// Token: 0x04010380 RID: 66432
		[Token(Token = "0x4010380")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Transform _projectileFolder;

		// Token: 0x04010381 RID: 66433
		[Token(Token = "0x4010381")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Transform _effectFolder;

		// Token: 0x04010382 RID: 66434
		[Token(Token = "0x4010382")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Transform _mapWidgetFolder;

		// Token: 0x04010383 RID: 66435
		[Token(Token = "0x4010383")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Transform _cameraFolder;

		// Token: 0x04010384 RID: 66436
		[Token(Token = "0x4010384")]
		private const string CAMERA_WITH_POSTPROCESS = "CameraController";

		// Token: 0x04010385 RID: 66437
		[Token(Token = "0x4010385")]
		private const string CAMERA_WITHOUT_POSTPROCESS = "LegacyCameraController";

		// Token: 0x04010386 RID: 66438
		[Token(Token = "0x4010386")]
		private const string CAMERA_PREFAB_WITH_POSTPROCESS = "Camera";

		// Token: 0x04010387 RID: 66439
		[Token(Token = "0x4010387")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_projectileFolder;

		// Token: 0x04010388 RID: 66440
		[Token(Token = "0x4010388")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_effectFolder;

		// Token: 0x04010389 RID: 66441
		[Token(Token = "0x4010389")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_characterFolder;

		// Token: 0x0401038A RID: 66442
		[Token(Token = "0x401038A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_mapWidgetFolder;

		// Token: 0x0401038B RID: 66443
		[Token(Token = "0x401038B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_CreateCamera;

		// Token: 0x0401038C RID: 66444
		[Token(Token = "0x401038C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_CreateCameraWithoutController;

		// Token: 0x0401038D RID: 66445
		[Token(Token = "0x401038D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_CreatePreviewCursor;

		// Token: 0x0401038E RID: 66446
		[Token(Token = "0x401038E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_CreateEnemy;

		// Token: 0x0401038F RID: 66447
		[Token(Token = "0x401038F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_CreateCharacter;

		// Token: 0x04010390 RID: 66448
		[Token(Token = "0x4010390")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_CreateToken;

		// Token: 0x04010391 RID: 66449
		[Token(Token = "0x4010391")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_TouchCharacter;

		// Token: 0x04010392 RID: 66450
		[Token(Token = "0x4010392")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_TouchToken;

		// Token: 0x04010393 RID: 66451
		[Token(Token = "0x4010393")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_CreateProjectile;

		// Token: 0x04010394 RID: 66452
		[Token(Token = "0x4010394")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_CreateSkill;

		// Token: 0x04010395 RID: 66453
		[Token(Token = "0x4010395")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_CreateSkin;

		// Token: 0x04010396 RID: 66454
		[Token(Token = "0x4010396")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_CreateEffect;

		// Token: 0x04010397 RID: 66455
		[Token(Token = "0x4010397")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_CreateCameraEffect;

		// Token: 0x04010398 RID: 66456
		[Token(Token = "0x4010398")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_CreateGlobalBuff;

		// Token: 0x04010399 RID: 66457
		[Token(Token = "0x4010399")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_CreateGlobalEnvSystem;

		// Token: 0x0401039A RID: 66458
		[Token(Token = "0x401039A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_CreateTile;

		// Token: 0x0401039B RID: 66459
		[Token(Token = "0x401039B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_CreateBlockedEdge;

		// Token: 0x0401039C RID: 66460
		[Token(Token = "0x401039C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_CreateDynamicAbility;

		// Token: 0x0401039D RID: 66461
		[Token(Token = "0x401039D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_AttachEquipIfNot;

		// Token: 0x0401039E RID: 66462
		[Token(Token = "0x401039E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
