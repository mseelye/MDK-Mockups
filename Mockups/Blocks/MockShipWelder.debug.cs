using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IngameScript.Mockups.Base;
using Sandbox.ModAPI;
using Sandbox.ModAPI.Interfaces;
using SpaceEngineers.Game.ModAPI.Ingame;
using VRage.Game;
using VRage.Game.Components;
using VRage.Game.Entity;
using VRage.Game.ModAPI;
using VRage.Game.Models;
using VRage.ModAPI;
using VRage.ObjectBuilders;
using VRage.Utils;
using VRageMath;
using VRageRender.Messages;

namespace IngameScript.Mockups.Blocks
{
#if !MOCKUP_DEBUG
    [System.Diagnostics.DebuggerNonUserCode]
#endif
    public class MockShipWelder : MockShipTool, IMyShipWelder
    {
        bool IMyFunctionalBlock.IsUpdateTimerCreated
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        bool IMyFunctionalBlock.IsUpdateTimerEnabled
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        IMyCubeGrid IMyCubeBlock.CubeGrid
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        MyResourceSinkComponentBase IMyCubeBlock.ResourceSink
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        Dictionary<string, float> IMyCubeBlock.UpgradeValues
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        IMySlimBlock IMyCubeBlock.SlimBlock
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        MyPhysicsComponentBase IMyEntity.Physics
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        MyPositionComponentBase IMyEntity.PositionComp
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        MyRenderComponentBase IMyEntity.Render
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        MyEntityComponentBase IMyEntity.GameLogic
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        MyHierarchyComponentBase IMyEntity.Hierarchy
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        MySyncComponentBase IMyEntity.SyncObject
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        MyModStorageComponentBase IMyEntity.Storage
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        EntityFlags IMyEntity.Flags
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        bool IMyEntity.MarkedForClose
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        bool IMyEntity.DebugAsyncLoading
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        bool IMyEntity.Save
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        MyPersistentEntityFlags2 IMyEntity.PersistentFlags
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        IMyModel IMyEntity.Model
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        IMyModel IMyEntity.ModelCollision
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        bool IMyEntity.Synchronized
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        MyEntityUpdateEnum IMyEntity.NeedsUpdate
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        IMyEntity IMyEntity.Parent
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        Matrix IMyEntity.LocalMatrix
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        bool IMyEntity.NearFlag
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        bool IMyEntity.CastShadows
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        bool IMyEntity.FastCastShadowResolve
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        bool IMyEntity.NeedsResolveCastShadow
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        float IMyEntity.MaxGlassDistSq
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        bool IMyEntity.NeedsDraw
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        bool IMyEntity.NeedsDrawFromParent
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        bool IMyEntity.Transparent
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        bool IMyEntity.ShadowBoxLod
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        bool IMyEntity.SkipIfTooSmall
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        bool IMyEntity.Visible
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        bool IMyEntity.NeedsWorldMatrix
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        bool IMyEntity.InScene
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        bool IMyEntity.InvalidateOnMove
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        MatrixD IMyEntity.WorldMatrixInvScaled
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        MatrixD IMyEntity.WorldMatrixNormalizedInv
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        bool IMyEntity.IsVolumetric
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        BoundingBox IMyEntity.LocalAABB
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        BoundingBox IMyEntity.LocalAABBHr
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        BoundingSphere IMyEntity.LocalVolume
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        Vector3 IMyEntity.LocalVolumeOffset
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        Vector3D IMyEntity.LocationForHudMarker
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        bool IMyEntity.IsCCDForProjectiles
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        bool IMyEntity.StopPhysicsActivation
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        bool Sandbox.ModAPI.Ingame.IMyShipWelder.HelpOthers
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        event Action<IMyTerminalBlock> IMyFunctionalBlock.EnabledChanged
        {
            add
            {
                throw new NotImplementedException();
            }

            remove
            {
                throw new NotImplementedException();
            }
        }

        event Action<IMyFunctionalBlock> IMyFunctionalBlock.UpdateTimerTriggered
        {
            add
            {
                throw new NotImplementedException();
            }

            remove
            {
                throw new NotImplementedException();
            }
        }

        event Action<IMyTerminalBlock> IMyTerminalBlock.CustomDataChanged
        {
            add
            {
                throw new NotImplementedException();
            }

            remove
            {
                throw new NotImplementedException();
            }
        }

        event Action<IMyTerminalBlock> IMyTerminalBlock.CustomNameChanged
        {
            add
            {
                throw new NotImplementedException();
            }

            remove
            {
                throw new NotImplementedException();
            }
        }

        event Action<IMyTerminalBlock> IMyTerminalBlock.OwnershipChanged
        {
            add
            {
                throw new NotImplementedException();
            }

            remove
            {
                throw new NotImplementedException();
            }
        }

        event Action<IMyTerminalBlock> IMyTerminalBlock.PropertiesChanged
        {
            add
            {
                throw new NotImplementedException();
            }

            remove
            {
                throw new NotImplementedException();
            }
        }

        event Action<IMyTerminalBlock> IMyTerminalBlock.ShowOnHUDChanged
        {
            add
            {
                throw new NotImplementedException();
            }

            remove
            {
                throw new NotImplementedException();
            }
        }

        event Action<IMyTerminalBlock> IMyTerminalBlock.VisibilityChanged
        {
            add
            {
                throw new NotImplementedException();
            }

            remove
            {
                throw new NotImplementedException();
            }
        }

        event Action<IMyTerminalBlock, StringBuilder> IMyTerminalBlock.AppendingCustomInfo
        {
            add
            {
                throw new NotImplementedException();
            }

            remove
            {
                throw new NotImplementedException();
            }
        }

        event Action<IMyCubeBlock> IMyCubeBlock.IsWorkingChanged
        {
            add
            {
                throw new NotImplementedException();
            }

            remove
            {
                throw new NotImplementedException();
            }
        }

        event Action IMyCubeBlock.OnUpgradeValuesChanged
        {
            add
            {
                throw new NotImplementedException();
            }

            remove
            {
                throw new NotImplementedException();
            }
        }

        event Action<IMyEntity> IMyEntity.OnClose
        {
            add
            {
                throw new NotImplementedException();
            }

            remove
            {
                throw new NotImplementedException();
            }
        }

        event Action<IMyEntity> IMyEntity.OnClosing
        {
            add
            {
                throw new NotImplementedException();
            }

            remove
            {
                throw new NotImplementedException();
            }
        }

        event Action<IMyEntity> IMyEntity.OnMarkForClose
        {
            add
            {
                throw new NotImplementedException();
            }

            remove
            {
                throw new NotImplementedException();
            }
        }

        event Action<IMyEntity> IMyEntity.OnPhysicsChanged
        {
            add
            {
                throw new NotImplementedException();
            }

            remove
            {
                throw new NotImplementedException();
            }
        }

        void IMyEntity.AddToGamePruningStructure()
        {
            throw new NotImplementedException();
        }

        void IMyCubeBlock.AddUpgradeValue(string upgrade, float defaultValue)
        {
            throw new NotImplementedException();
        }

        void IMyEntity.BeforeSave()
        {
            throw new NotImplementedException();
        }

        void IMyCubeBlock.CalcLocalMatrix(out Matrix localMatrix, out string currModel)
        {
            throw new NotImplementedException();
        }

        string IMyCubeBlock.CalculateCurrentModel(out Matrix orientation)
        {
            throw new NotImplementedException();
        }

        void IMyEntity.Close()
        {
            throw new NotImplementedException();
        }

        void IMyEntity.DebugDraw()
        {
            throw new NotImplementedException();
        }

        void IMyEntity.DebugDrawInvalidTriangles()
        {
            throw new NotImplementedException();
        }

        void IMyEntity.Delete()
        {
            throw new NotImplementedException();
        }

        bool IMyEntity.DoOverlapSphereTest(float sphereRadius, Vector3D spherePos)
        {
            throw new NotImplementedException();
        }

        void IMyEntity.EnableColorMaskForSubparts(bool enable)
        {
            throw new NotImplementedException();
        }

        void IMyEntity.GetChildren(List<IMyEntity> children, Func<IMyEntity, bool> collect)
        {
            throw new NotImplementedException();
        }

        Vector3 IMyEntity.GetDiffuseColor()
        {
            throw new NotImplementedException();
        }

        float IMyEntity.GetDistanceBetweenCameraAndBoundingSphere()
        {
            throw new NotImplementedException();
        }

        float IMyEntity.GetDistanceBetweenCameraAndPosition()
        {
            throw new NotImplementedException();
        }

        uint IMyFunctionalBlock.GetFramesFromLastTrigger()
        {
            throw new NotImplementedException();
        }

        string IMyEntity.GetFriendlyName()
        {
            throw new NotImplementedException();
        }

        bool IMyEntity.GetIntersectionWithAABB(ref BoundingBoxD aabb)
        {
            throw new NotImplementedException();
        }

        bool IMyEntity.GetIntersectionWithLine(ref LineD line, out MyIntersectionResultLineTriangleEx? tri, IntersectionFlags flags)
        {
            throw new NotImplementedException();
        }

        Vector3D? IMyEntity.GetIntersectionWithLineAndBoundingSphere(ref LineD line, float boundingSphereRadiusMultiplier)
        {
            throw new NotImplementedException();
        }

        bool IMyEntity.GetIntersectionWithSphere(ref BoundingSphereD sphere)
        {
            throw new NotImplementedException();
        }

        IMyInventory IMyEntity.GetInventory()
        {
            throw new NotImplementedException();
        }

        IMyInventory IMyEntity.GetInventory(int index)
        {
            throw new NotImplementedException();
        }

        float IMyEntity.GetLargestDistanceBetweenCameraAndBoundingSphere()
        {
            throw new NotImplementedException();
        }

        MyObjectBuilder_EntityBase IMyEntity.GetObjectBuilder(bool copy)
        {
            throw new NotImplementedException();
        }

        MyObjectBuilder_CubeBlock IMyCubeBlock.GetObjectBuilderCubeBlock(bool copy)
        {
            throw new NotImplementedException();
        }

        float IMyEntity.GetSmallestDistanceBetweenCameraAndBoundingSphere()
        {
            throw new NotImplementedException();
        }

        MyEntitySubpart IMyEntity.GetSubpart(string name)
        {
            throw new NotImplementedException();
        }

        IMyEntity IMyEntity.GetTopMostParent(Type type)
        {
            throw new NotImplementedException();
        }

        void IMyEntity.GetTrianglesIntersectingSphere(ref BoundingSphere sphere, Vector3? referenceNormalVector, float? maxAngle, List<MyTriangle_Vertex_Normals> retTriangles, int maxNeighbourTriangles)
        {
            throw new NotImplementedException();
        }

        MatrixD IMyEntity.GetViewMatrix()
        {
            throw new NotImplementedException();
        }

        MatrixD IMyEntity.GetWorldMatrixNormalizedInv()
        {
            throw new NotImplementedException();
        }

        void IMyCubeBlock.Init()
        {
            throw new NotImplementedException();
        }

        void IMyCubeBlock.Init(MyObjectBuilder_CubeBlock builder, IMyCubeGrid cubeGrid)
        {
            throw new NotImplementedException();
        }

        bool IMyTerminalBlock.IsInSameLogicalGroupAs(IMyTerminalBlock other)
        {
            throw new NotImplementedException();
        }

        bool IMyTerminalBlock.IsSameConstructAs(IMyTerminalBlock other)
        {
            throw new NotImplementedException();
        }

        bool IMyEntity.IsVisible()
        {
            throw new NotImplementedException();
        }

        bool IMyShipWelder.IsWithinWorldLimits(IMyProjector projector, string name, int pcuToBuild)
        {
            throw new NotImplementedException();
        }

        void IMyEntity.OnAddedToScene(object source)
        {
            throw new NotImplementedException();
        }

        void IMyCubeBlock.OnBuildSuccess(long builtBy)
        {
            throw new NotImplementedException();
        }

        void IMyCubeBlock.OnBuildSuccess(long builtBy, bool instantBuild)
        {
            throw new NotImplementedException();
        }

        void IMyCubeBlock.OnDestroy()
        {
            throw new NotImplementedException();
        }

        void IMyCubeBlock.OnModelChange()
        {
            throw new NotImplementedException();
        }

        void IMyCubeBlock.OnRegisteredToGridSystems()
        {
            throw new NotImplementedException();
        }

        void IMyCubeBlock.OnRemovedByCubeBuilder()
        {
            throw new NotImplementedException();
        }

        void IMyEntity.OnRemovedFromScene(object source)
        {
            throw new NotImplementedException();
        }

        void IMyCubeBlock.OnUnregisteredFromGridSystems()
        {
            throw new NotImplementedException();
        }

        string IMyCubeBlock.RaycastDetectors(Vector3D worldFrom, Vector3D worldTo)
        {
            throw new NotImplementedException();
        }

        void IMyTerminalBlock.RefreshCustomInfo()
        {
            throw new NotImplementedException();
        }

        void IMyCubeBlock.ReloadDetectors(bool refreshNetworks)
        {
            throw new NotImplementedException();
        }

        int IMyCubeBlock.RemoveEffect(string effectName, int exception)
        {
            throw new NotImplementedException();
        }

        void IMyEntity.RemoveFromGamePruningStructure()
        {
            throw new NotImplementedException();
        }

        void IMyEntity.SetColorMaskForSubparts(Vector3 colorMaskHsv)
        {
            throw new NotImplementedException();
        }

        void IMyCubeBlock.SetDamageEffect(bool start)
        {
            throw new NotImplementedException();
        }

        bool IMyCubeBlock.SetEffect(string effectName, bool stopPrevious)
        {
            throw new NotImplementedException();
        }

        bool IMyCubeBlock.SetEffect(string effectName, float parameter, bool stopPrevious, bool ignoreParameter, bool removeSameNameEffects)
        {
            throw new NotImplementedException();
        }

        void IMyEntity.SetEmissiveParts(string emissiveName, Color emissivePartColor, float emissivity)
        {
            throw new NotImplementedException();
        }

        void IMyEntity.SetEmissivePartsForSubparts(string emissiveName, Color emissivePartColor, float emissivity)
        {
            throw new NotImplementedException();
        }

        void IMyEntity.SetLocalMatrix(Matrix localMatrix, object source)
        {
            throw new NotImplementedException();
        }

        void IMyEntity.SetPosition(Vector3D pos)
        {
            throw new NotImplementedException();
        }

        void IMyEntity.SetTextureChangesForSubparts(Dictionary<string, MyTextureChange> value)
        {
            throw new NotImplementedException();
        }

        void IMyEntity.SetWorldMatrix(MatrixD worldMatrix, object source)
        {
            throw new NotImplementedException();
        }

        void IMyEntity.Teleport(MatrixD pos, object source, bool ignoreAssert)
        {
            throw new NotImplementedException();
        }

        bool IMyEntity.TryGetSubpart(string name, out MyEntitySubpart subpart)
        {
            throw new NotImplementedException();
        }

        void IMyEntity.UpdateGamePruningStructure()
        {
            throw new NotImplementedException();
        }
    }
}
