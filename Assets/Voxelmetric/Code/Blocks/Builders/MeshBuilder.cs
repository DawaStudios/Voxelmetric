﻿using System.Collections;
using UnityEngine;

public class MeshBuilder {

    public static void CrossMeshRenderer(Chunk chunk, BlockPos pos, MeshData meshData, Tile tilePos, Block block)
    {
        float halfBlock = 0.5005f;
        float colliderOffest = 0.05f;
        float blockHeight = halfBlock * 2 * (block.data2 / 255f);

        float blockLight = ( (block.data1/255f) * Config.Env.BlockLightStrength) + (0.8f*Config.Env.AOStrength);

        meshData.AddVertex(new Vector3(pos.x - halfBlock, pos.y - halfBlock, pos.z + halfBlock));
        meshData.AddVertex(new Vector3(pos.x - halfBlock, pos.y - halfBlock + blockHeight, pos.z + halfBlock));
        meshData.AddVertex(new Vector3(pos.x + halfBlock, pos.y - halfBlock + blockHeight, pos.z - halfBlock));
        meshData.AddVertex(new Vector3(pos.x + halfBlock, pos.y - halfBlock, pos.z - halfBlock));
        meshData.AddQuadTriangles();
        BlockBuilder.BuildTexture(chunk, pos, meshData, Direction.north, tilePos);
        meshData.AddColors(blockLight, blockLight, blockLight, blockLight, blockLight);

        meshData.AddVertex(new Vector3(pos.x + halfBlock, pos.y - halfBlock, pos.z - halfBlock));
        meshData.AddVertex(new Vector3(pos.x + halfBlock, pos.y - halfBlock + blockHeight, pos.z - halfBlock));
        meshData.AddVertex(new Vector3(pos.x - halfBlock, pos.y - halfBlock + blockHeight, pos.z + halfBlock));
        meshData.AddVertex(new Vector3(pos.x - halfBlock, pos.y - halfBlock, pos.z + halfBlock));
        meshData.AddQuadTriangles();
        BlockBuilder.BuildTexture(chunk, pos, meshData, Direction.north, tilePos);
        meshData.AddColors(blockLight, blockLight, blockLight, blockLight, blockLight);

        meshData.AddVertex(new Vector3(pos.x + halfBlock, pos.y - halfBlock, pos.z + halfBlock));
        meshData.AddVertex(new Vector3(pos.x + halfBlock, pos.y - halfBlock + blockHeight, pos.z + halfBlock));
        meshData.AddVertex(new Vector3(pos.x - halfBlock, pos.y - halfBlock + blockHeight, pos.z - halfBlock));
        meshData.AddVertex(new Vector3(pos.x - halfBlock, pos.y - halfBlock, pos.z - halfBlock));
        meshData.AddQuadTriangles();
        BlockBuilder.BuildTexture(chunk, pos, meshData, Direction.north, tilePos);
        meshData.AddColors(blockLight, blockLight, blockLight, blockLight, blockLight);

        meshData.AddVertex(new Vector3(pos.x - halfBlock, pos.y - halfBlock, pos.z - halfBlock));
        meshData.AddVertex(new Vector3(pos.x - halfBlock, pos.y - halfBlock + blockHeight, pos.z - halfBlock));
        meshData.AddVertex(new Vector3(pos.x + halfBlock, pos.y - halfBlock + blockHeight, pos.z + halfBlock));
        meshData.AddVertex(new Vector3(pos.x + halfBlock, pos.y - halfBlock, pos.z + halfBlock));
        meshData.AddQuadTriangles();
        BlockBuilder.BuildTexture(chunk, pos, meshData, Direction.north, tilePos);
        meshData.AddColors(blockLight, blockLight, blockLight, blockLight, blockLight);

        meshData.AddVertex(new Vector3(pos.x - halfBlock, pos.y - halfBlock + colliderOffest, pos.z + halfBlock), collisionMesh: true);
        meshData.AddVertex(new Vector3(pos.x + halfBlock, pos.y - halfBlock + colliderOffest, pos.z + halfBlock), collisionMesh: true);
        meshData.AddVertex(new Vector3(pos.x + halfBlock, pos.y - halfBlock + colliderOffest, pos.z - halfBlock), collisionMesh: true);
        meshData.AddVertex(new Vector3(pos.x - halfBlock, pos.y - halfBlock + colliderOffest, pos.z - halfBlock), collisionMesh: true);
        meshData.AddQuadTriangles(collisionMesh:true);
    }
}
